using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;

using AR600ROSControlCore.DataTypes.RobotMessages;

namespace AR600ROSControlWPF.ViewModels
{
    public class JointListViewModel : INotifyPropertyChanged
    {
        public class JointInfo:INotifyPropertyChanged
        {
            string name;
            float lowerLimit;
            float upperLimit;
            float position;

            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
            public float LowerLimit
            {
                get { return lowerLimit; }
                set
                {
                    lowerLimit = value;
                    OnPropertyChanged("LowerLimit");
                }
            }
            public float UpperLimit
            {
                get { return upperLimit; }
                set
                {
                    upperLimit = value;
                    OnPropertyChanged("UpperLimit");
                }
            }
            public float Position
            {
                get { return position; }
                set
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName]string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        List<JointInfo> joints = new List<JointInfo>();

        public List<JointInfo> Joints
        {
            get { return joints; }
            set
            {
                joints = value;
                OnPropertyChanged("Joints");
            }
        }
    
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
