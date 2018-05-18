using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZedGraph;

namespace AR600ROSControlGUI.Views
{
    public partial class GraphView : UserControl
    {
        // Получим панель для рисования
        GraphPane pane;

        public GraphView()
        {
            InitializeComponent();

            pane = graph.GraphPane;
            WidgetsInit();
        }

        private void WidgetsInit()
        {
            pane.IsFontsScaled = false;
            pane.XAxis.Title.Text = "Время, сек";
        }

        public void setTitle(string title)
        {
            pane.Title.Text = title;
        }

        public void setYAxisTitle(string title)
        {
            pane.YAxis.Title.Text = title;
        }
    }
}
