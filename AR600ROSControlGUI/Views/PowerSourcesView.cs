using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ViewLibrary;
using AR600ROSControlCore;
using AR600ROSControlCore.DataTypes.RobotMessages;

namespace AR600ROSControlGUI.Views
{
    public partial class PowerSourcesView : UserControl
    {
        RobotDriverClient robot_;
        Timer timer = new Timer();
        SourcesSupplyState state_ = new SourcesSupplyState();

        private bool isPowerOn = false;

        public PowerSourcesView()
        {
            InitializeComponent();
            WidgetsInit();
            
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            update(state_);
        }

        public void setRobotDriverClient(ref RobotDriverClient robot)
        {
            robot_ = robot;
            robot_.updateSourcesState += OnUpdateSourcesState;
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void OnUpdateSourcesState(SourcesSupplyState sourcesState)
        {
            state_ = sourcesState;
            //powerStateGrid.Invoke(new Action(() => update(sourcesState)));
        }

        private void update(SourcesSupplyState state)
        {
            UpdateSourceState(0, state.S12);
            UpdateSourceState(1, state.S48);
            UpdateSourceState(2, state.S8_1);
            UpdateSourceState(3, state.S8_2);
            UpdateSourceState(4, state.S6_1);
            UpdateSourceState(5, state.S6_2);
        }

        private void UpdateSourceState(int row, TypeSupplyState state)
        {
            if (state == null) return;
            powerStateGrid[1, row].Value = state.Voltage;
            powerStateGrid[2, row].Value = state.Current;
        }

        private void WidgetsInit()
        {
            ViewStyler.styleGrid(ref powerStateGrid);

            powerStateGrid.RowCount = 6;
            powerStateGrid[0, 0].Value = "12 Вольт";
            powerStateGrid[0, 1].Value = "48 Вольт";
            powerStateGrid[0, 2].Value = "8 Вольт (1)";
            powerStateGrid[0, 3].Value = "8 Вольт (2)";
            powerStateGrid[0, 4].Value = "6 Вольт (1)";
            powerStateGrid[0, 5].Value = "6 Вольт (2)";

            for(int i = 0; i < 6; i++)
            {
                powerStateGrid[1, i].Value = "0.00";
                powerStateGrid[2, i].Value = "0.00";
            }
        }

        private void onOffButton_Click(object sender, EventArgs e)
        {
            if(isPowerOn == true)
                onOffButton.BackgroundImage = Properties.Resources.off;
            else
                onOffButton.BackgroundImage = Properties.Resources.on;
            isPowerOn = !isPowerOn;

            setPower(isPowerOn);
        }

        private void setPower(bool powerOn)
        {

        }
    }
}
