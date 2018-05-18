using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AR600ROSControlCore;

namespace AR600ControlConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            RobotDriverClient robot = new RobotDriverClient();
            //Task task = robot.ConnectAsync(new Uri("ws://192.168.0.100:9090"));
            robot.ConnectAsync(new Uri("ws://192.168.1.140:9090")).Wait();


            Console.WriteLine("Соединение с ROSBRIDGE установленно");

            //while (!robot.isLoaded) ;

            //Console.WriteLine(
            //        String.Format("{0,-30} | {1,-10} | {2,-15} | {3,-15} | {4,-10} | {5,-10}\n",
            //        "Название привода",
            //        "Включен",
            //        "Левый предел",
            //        "Правый предел",
            //        "Смещение",
            //        "Реверс")
            //        );

            //for (int i = 0; i < robot.jointsParams.names.Count; i++)
            //{

            //    Console.WriteLine(
            //        String.Format("{0,-30} | {1,-10} | {2,-15} | {3,-15} | {4,-10} | {5,-10}",
            //        robot.jointsParams.names[i],
            //        robot.jointsParams.enabled[i],
            //        robot.jointsParams.lower_limit[i],
            //        robot.jointsParams.upper_limit[i],
            //        robot.jointsParams.offset[i],
            //        robot.jointsParams.reverse[i])
            //        );
            //}


            Console.ReadLine();
        }
    }
}
