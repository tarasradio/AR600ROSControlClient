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
    public partial class SensorsListView : UserControl
    {
        public SensorsListView()
        {
            InitializeComponent();
            WidgetsInit();
        }

        private void WidgetsInit()
        {
            ViewStyler.styleGrid(ref sensorsGrid);

            sensorsGrid.RowCount = 11;
            sensorsGrid[0, 0].Value = 1;
            sensorsGrid[0, 1].Value = 2;
            sensorsGrid[0, 2].Value = 3;

            sensorsGrid[1, 0].Value = "Инерциальные";
            sensorsGrid[1, 1].Value = "Инерциальные";
            sensorsGrid[1, 2].Value = "Инерциальные";

            sensorsGrid[2, 0].Value = "Гироскоп X";
            sensorsGrid[2, 1].Value = "Гироскоп Y";
            sensorsGrid[2, 2].Value = "Гироскоп Z";

            sensorsGrid[3, 0].Value = "123";
            sensorsGrid[3, 1].Value = "456";
            sensorsGrid[3, 2].Value = "-56";

            sensorsGraph.setTitle("Данные с датчиков");
            sensorsGraph.setYAxisTitle("Значение");
        }
    }
}
