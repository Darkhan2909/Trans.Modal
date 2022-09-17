using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trans.Modal.Modals;

namespace Trans.Modal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Car car = new Car();
            RandomCars cars = new RandomCars();


            for (int i = 0; i < 10; i++)
            {
                var ThisCar = new Car();

                ThisCar.Brand = "Subaru";
                ThisCar.Number = i;
                ThisCar.Speed = 260;

                cars.AddTrans(new Car(random.Next(450)));
                //Console.WriteLine(ThisCar);
            }

            cars.PrintInfo();

            Console.WriteLine(cars);
        }
    }

    public interface ITrans
    {

    }
    public interface ITransMethods
    {
        void PrintInfo();
        void CalculetaInfo();
    }

    public interface ITransParam
    {
        string VinCode { get; set; }
        string Color { get; set; }
        bool IsAirplane { get; set; }
    }

    public class Transport : ITrans, ITransMethods, ITransParam
    {
        public string CarType { get; set; }
        public string CarBrand { get; set; }

       

        void ITransMethods.PrintInfo()
        {

        }

        void ITransMethods.CalculetaInfo()
        {

        }

        string VinCode { get; set; }
        string Color { get; set; }
        bool IsAirplane { get; set; }
        string ITransParam.VinCode { get; set; }
        string ITransParam.Color { get; set; }
        bool ITransParam.IsAirplane { get; set; }
    }
}
