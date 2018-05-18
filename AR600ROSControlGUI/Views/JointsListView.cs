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
using AR600ROSControlCore.DataTypes.SensorMessages;
using AR600ROSControlCore.TypeConverters;

using AR600ROSControlGUI.Utils;

namespace AR600ROSControlGUI.Views
{
    public partial class JointsListView : UserControl
    {
        private RobotDriverClient robot_;
        Timer timer = new Timer();
        JointsParams jointsParams_ = new JointsParams();
        JointState jointState_ = new JointState();

        public JointsListView()
        {
            InitializeComponent();
            WidgetsInit();

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            updateJointsParams(jointsParams_);
            updateJointState(jointState_);
        }

        private void WidgetsInit()
        {
            ViewStyler.styleGrid(ref jointsGrid);

            jointsGrid.RowCount = 21;
            for(int i = 0; i < 21; i++)
            {
                int number = i + 1;
                jointsGrid[0, i].Value = number.ToString();
            }
        }

        public void setRobotDriverClient(ref RobotDriverClient robot)
        {
            robot_ = robot;
            robot_.updateJointParams += OnUpdateJointParams;
            robot_.updateJointState += OnUpdateJointState;
            timer.Start();
        }

        private void OnUpdateJointState(JointState jointState)
        {
            jointState_ = jointState;
        }

        private void OnUpdateJointParams(JointsParams jointsParams)
        {
            jointsParams_ = jointsParams;
            //jointsGrid.Invoke(new Action(() => update(jointsParams)));
        }

        private void updateJointState(JointState jointState)
        {
            if (jointState_.name == null) return;
            for (int i = 0; i < jointState.name.Count; i++)
            {
                jointsGrid[2, i].Value = 
                    AngleConverter.RadianToDegrees(jointState.position[i]).ToString("F2");
            }
        }

        private void updateJointsParams(JointsParams jointsParams)
        {
            if (jointsParams.names == null) return;
            for(int i = 0; i < jointsParams.names.Count; i++)
            {
                jointsGrid[1, i].Value = jointsParams.names[i];
                jointsGrid[3, i].Value = TypeJointModeConverter.getString(jointsParams.mode[i]);
                jointsGrid[4, i].Value = jointsParams.lower_limit[i];
                jointsGrid[5, i].Value = jointsParams.upper_limit[i];
            }
        }
    }
}
