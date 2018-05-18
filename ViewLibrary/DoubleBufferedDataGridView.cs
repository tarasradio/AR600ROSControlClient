using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ViewLibrary
{
    public class DoubleBufferedDataGridView : DataGridView
    {
        public DoubleBufferedDataGridView() : base()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
