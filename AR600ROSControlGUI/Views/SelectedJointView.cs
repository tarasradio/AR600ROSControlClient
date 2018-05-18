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

namespace AR600ROSControlGUI.Views
{
    public partial class SelectedJointView : UserControl
    {
        static string notSetText = "Не задано";
        public SelectedJointView()
        {
            InitializeComponent();
            WidgetsInit();
        }

        private void WidgetsInit()
        {
            ViewStyler.styleGrid(ref jointParamsGrid);

            jointParamsGrid.RowCount = 4;
            jointParamsGrid[0, 0].Value = "Номер";
            jointParamsGrid[0, 1].Value = "Включен";
            jointParamsGrid[0, 2].Value = "Статус";
            jointParamsGrid[0, 3].Value = "За пределами";

            for (int i = 0; i < 4; i++)
                jointParamsGrid[1, i].Value = notSetText;

            lowerLimitLable.Text = notSetText;
            upperLimitLable.Text = notSetText;
            currentPositionLable.Text = notSetText;
        }
    }
}
