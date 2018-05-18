using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AR600ROSControlCore;
using System.Threading;
using System.Net.WebSockets;
using System.Configuration;

using AR600ROSControlCore.DataTypes.TransitionActionMessages;

using FrundController;

namespace AR600ROSControlGUI
{
    public partial class MainForm : Form
    {
        enum LinkStatus
        {
            NOT_CONNECTED,
            CONNECTING,
            DISCONNECTING,
            CONNECTED
        };

        ROSBridgeClient bridgeClient;

        RobotDriverClient robotDriver;
        TransitionControllerClient transitionController;
        FrundControllerClient frundController;

        LinkStatus masterLinkStatus;
        Uri masterUri;

        System.Windows.Forms.Timer timer;

        TransitionActionFeedback transitionFeedback_ = new TransitionActionFeedback();

        public MainForm()
        {
            InitializeComponent();
            setMasterLinkState(LinkStatus.NOT_CONNECTED);            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bridgeClient = new ROSBridgeClient();

            robotDriver = new RobotDriverClient();
            transitionController = new TransitionControllerClient();
            frundController = new FrundControllerClient();

            bridgeClient.Clients.Add(robotDriver);
            bridgeClient.Clients.Add(transitionController);
            bridgeClient.Clients.Add(frundController);
            
            WidgetsInit();
            LoadDefaultUri();

            jointsListView.setRobotDriverClient(ref robotDriver);
            powerSourcesView.setRobotDriverClient(ref robotDriver);
            frundControllerView.setFrundControllerClient(ref frundController);

            transitionController.updateTransitionFeedback += OnUpdateTransitionFeedback;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            transitionProgressBar.Value = (int)(transitionFeedback_.feedback.percentage);
        }

        private void OnUpdateTransitionFeedback(TransitionActionFeedback transitionFeedback)
        {
            transitionFeedback_ = transitionFeedback;
            Console.WriteLine(transitionFeedback.feedback.percentage);
        }

        private void activateWidgets(bool isActive)
        {
            jointsListView.Enabled = isActive;
            sensorsListView.Enabled = isActive;
            selectedJointView.Enabled = isActive;
            graphView.Enabled = isActive;
            powerSourcesView.Enabled = isActive;
        }

        private async void connectToMasterButton_Click(object sender, EventArgs e)
        {
            if (masterLinkStatus == LinkStatus.NOT_CONNECTED)
            {
                if (!String.IsNullOrWhiteSpace(editMasterUri.Text))
                {
                    try
                    {
                        masterUri = new Uri(editMasterUri.Text);
                    }
                    catch (UriFormatException ex)
                    {
                        MessageBox.Show("Неверный формат URI", "Ошибка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                   
                    await ConnectToMaster(masterUri);
                }
                else
                    MessageBox.Show("URI мастера не задан", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (masterLinkStatus == LinkStatus.CONNECTED)
            {
                await DisconnectFromMaster();
            }
        }

        // Чтение адреса мастера
        void LoadDefaultUri()
        {
            string uri = ConfigurationManager.AppSettings["MasterUri"];
            if (uri != null)
                editMasterUri.Text = uri;
        }

        // Подключение к Master
        private async Task ConnectToMaster(Uri uri)
        {            
            try
            {
                setMasterLinkState(LinkStatus.CONNECTING);

                await bridgeClient.ConnectAsync(uri);

                setMasterLinkState(LinkStatus.CONNECTED);
            }
            catch (WebSocketException ex)
            {
                setMasterLinkState(LinkStatus.NOT_CONNECTED);
                MessageBox.Show("Не удалось подключиться к MasterNode", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task DisconnectFromMaster()
        {
            setMasterLinkState(LinkStatus.DISCONNECTING);
            powerSourcesView.Stop();

            await bridgeClient.DisconnectAsync();

            setMasterLinkState(LinkStatus.NOT_CONNECTED);
        }

        private void WidgetsInit()
        {
            SelectControllerBox.SelectedIndex = 0;

            graphView.setTitle("Положения приводов");
            graphView.setYAxisTitle("Угол, радиан");
        }

        private void setMasterLinkState(LinkStatus status)
        {
            masterLinkStatus = status;

            if (status == LinkStatus.NOT_CONNECTED)
            {
                lableMasterLinkState.Text = "Соединение с MasterNode не установленно";
                lableMasterLinkState.ForeColor = Color.Brown;
                connectToMasterButton.Text = "Подключиться";
                connectToMasterButton.Enabled = true;
                //activateWidgets(false);
            }
            else if(status == LinkStatus.CONNECTED)
            {                
                lableMasterLinkState.Text = String.Format("Соединение с MasterNode [{0}] установлено", masterUri.ToString());
                lableMasterLinkState.ForeColor = Color.Green;
                connectToMasterButton.Text = "Отключиться";
                connectToMasterButton.Enabled = true;
                //activateWidgets(true);
            }
            else if(status == LinkStatus.CONNECTING)
            {
                lableMasterLinkState.Text = String.Format("Соединение с MasterNode [{0}]...", masterUri.ToString());
                lableMasterLinkState.ForeColor = Color.Blue;
                connectToMasterButton.Enabled = false;
            }
            else if (status == LinkStatus.DISCONNECTING)
            {
                lableMasterLinkState.Text = "Отключение от MasterNode";
                lableMasterLinkState.ForeColor = Color.Blue;
                connectToMasterButton.Enabled = false;
            }
        }

        private void initPosButton_Click(object sender, EventArgs e)
        {
            string goal_id = Guid.NewGuid().ToString();
            transitionController.startTransition(goal_id, robotDriver.jointsParams_.names);
            transitionProgressBar.Value = 0;
        }

        private void stopTransitButton_Click(object sender, EventArgs e)
        {
            transitionController.cancelTransition("");
            transitionProgressBar.Value = 0;
        }
    }
}
