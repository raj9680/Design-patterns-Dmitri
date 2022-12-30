using System;

namespace Abstract_Factory_1
{
    /* Interfaces
     */
    public interface ICar { }
    public interface IBike { }


    public class TataCar: ICar
    {
        public void Manufacture() { }
    }
    public class TataBike: IBike
    {
        public void Manufacture() { }
    }


    public class TeslaCar: ICar
    {
        public void Manufacture() { }
    }
    public class TeslaBike : IBike
    {
        public void Manufacture() { }
    }

    
    /* Abstract Factory :- This is abstract factory which will return factory of similar objects
     * example: Tata, Tesla etc.
     */
    public abstract class VehicleCompany
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }


    /* This is a factory of similar objects which will actually create the objects.
     */
    public class TeslaCompany : VehicleCompany
    {
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

        public override ICar GetCar()
        {
            return new TeslaCar();
        }
    }

    /* This is a factory of similar objects which will actually create the objects.
     */
    public class TataCompany : VehicleCompany
    {
        public override IBike GetBike()
        {
            return new TataBike();
        }

        public override ICar GetCar()
        {
            return new TataCar();
        }
    }



    /* Mains
     */
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCompany teslaCarCompany = new TeslaCompany();
            IBike teslaBike = teslaCarCompany.GetBike();
            ICar teslaCar = teslaCarCompany.GetCar();
            Console.WriteLine($"Object of TeslaBike: {teslaBike}, Object of TeslaCar: {teslaCar}\n");


            VehicleCompany tataCarCompany = new TataCompany();
            IBike tataBike = tataCarCompany.GetBike();
            ICar tataCar = tataCarCompany.GetCar();
            Console.WriteLine($"Object of TataBike: {tataBike}, Object of TataCar: {tataCar}");
        }
    }
}
