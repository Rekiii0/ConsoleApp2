using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class vehicle
    {
        public string brand;
    }
        class MotorVehicle : vehicle
        {
            public string modelName;
        }
        class Car : MotorVehicle
        {

        }
        class truck : MotorVehicle
        {

        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.brand = "kai";
            MyCar.modelName = "sportage";
            truck MyTruck = new truck();
            MyTruck.brand = "volvo";
            MyTruck.modelName = "FH";
            Console.WriteLine("my car brand and modelm is" + MyCar.brand + "and" + MyCar.modelName);
            Console.WriteLine("my truck brand and modelm is" + MyTruck.brand + "and" + MyTruck.modelName);
            Console.ReadLine();
        }
    }
}
