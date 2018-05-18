using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore.DataTypes.SensorMessages
{
    public class ImuSensor
    {
        public GeometryMessages.Quaternion orientation { get; set; }
        public double[] orientation_covariance { get; set; }
        public GeometryMessages.Vector3 angular_velocity { get; set; }
        public double[] angular_velocity_covariance { get; set; }
        public GeometryMessages.Vector3 linear_acceleration { get; set; }
        public double[] linear_acceleration_covariance { get; set; }

        public ImuSensor()
        {
            orientation = new GeometryMessages.Quaternion();
            orientation_covariance = new double[9];
            angular_velocity = new GeometryMessages.Vector3();
            angular_velocity_covariance = new double[9];
            linear_acceleration = new GeometryMessages.Vector3();
            linear_acceleration_covariance = new double[9];
        }
    }
}
