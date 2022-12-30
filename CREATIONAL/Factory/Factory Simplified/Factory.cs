using Factory_Simplifiedd;

namespace Factory_Simplified
{
    public interface ICar
    {
        public string Start();
    }

    public class SixSeaterCar : ICar
    {
        public string Start()
        {
            return "Six Seater Car Started";
        }
    }
    public class FourSeaterCar : ICar
    {
        public string Start()
        {
            return "Four Seater Car Started";
        }
    }


    // Separate Factory for handling object creation task
    public class CarFactory
    {
        public ICar CreateFactory(string CarType)
        {
            switch (CarType)
            {
                case "Six Seater Car":
                    return new SixSeaterCar();

                case "Four Seater Car":
                    return new FourSeaterCar();

                default:
                    break;
            }
            return null;
        }
    }
    

    class Factory
    {
        static void Main(string[] args)
        {
            /* For Factory
             * 
            CarFactory CarFactory = new CarFactory();
            ICar SixSeaterCar = CarFactory.CreateFactory("Six Seater Car");
            Console.WriteLine(SixSeaterCar.Start());
            */


            /* For Abstract Factory */
            VehicleCompany vehicleCompany = new TeslaCompany();

            Factory_Simplifiedd.IBike TeslaBike = vehicleCompany.GetBike();
            System.Console.WriteLine(TeslaBike);

            Factory_Simplifiedd.ICar TeslaCar = vehicleCompany.GetCar();
            System.Console.WriteLine(TeslaCar);
        }
    }
}
