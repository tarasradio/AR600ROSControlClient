using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using AR600ROSControlWPF.ViewModels;

namespace AR600ROSControlWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            JointListViewModel model = new JointListViewModel();
            
            model.Joints.Add(new JointListViewModel.JointInfo() { Name = "joint", LowerLimit = -5, UpperLimit = 5, Position = 0 });

            jointListView.DataContext = model;
        }
    }
}
