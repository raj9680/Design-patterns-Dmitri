using System;

/* Factory Method: Factory Method responsible for instantiating the object but the instatiation logic will be delegated to
 * sub class inheriting the factory.
 */
namespace Factory_Method
{
    public interface IVehicle
    {
        public void Manufacture();
    }


    /* Tata
     */
    public class TataCar : IVehicle
    {
        public void Manufacture() { }
    }
    public class TataBus : IVehicle
    {
        public void Manufacture() { }
    }


    /* Tesla
     */
    public class TeslaCar : IVehicle
    {
        public void Manufacture() { }
    }
    public class TeslaBus : IVehicle
    {
        public void Manufacture() { }
    }



    /* Factory Class
     */
    public abstract class CarCompany
    {
        public IVehicle ProduceVehicle(string vehicleType)
        {
            IVehicle vehicle = ManufactureVehicle(vehicleType);
            vehicle.Manufacture();
            return vehicle;
        }

        protected abstract IVehicle ManufactureVehicle(string vehicleType);
    }


    /* Base class 1 inheriting Factory Class
     */
    public class TeslaCompany : CarCompany
    {
        protected override IVehicle ManufactureVehicle(string vehicleType)
        {
            if (vehicleType.Contains("Car"))
            {
                return new TeslaCar();
            }
            else
            {
                return new TeslaBus();
            }
        }
    }

    /* Base class 2 inheriting Factory Class
     */
    public class TataCompany : CarCompany
    {
        protected override IVehicle ManufactureVehicle(string vehicleType)
        {
            if (vehicleType.Contains("Car"))
            {
                return new TataCar();
            }
            else
            {
                return new TataBus();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            CarCompany teslaCarCompany = new TeslaCompany();
            IVehicle teslaCar = teslaCarCompany.ProduceVehicle("Car");
            Console.WriteLine($"Tesla Car Object {teslaCar}");

            IVehicle teslaBus = teslaCarCompany.ProduceVehicle("Bus");
            Console.WriteLine($"Tesla Bus Object {teslaBus}");
        }
    }
}
