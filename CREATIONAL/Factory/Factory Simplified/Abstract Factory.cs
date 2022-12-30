using System;
using System.Collections.Generic;
using System.Text;

/* Abstract Factory
 * Abstract factory return the factory, and using that factory we creates object as per need.
 * Benefits:
 * 1). It hides instantiation logic
 * 2). Reduces the code duplicacy.
 * 3). Change at one place, changes affect at all places.
 * 4). You can use request the factory for a factory which will used to create one category of objects.
 */
namespace Factory_Simplifiedd
{
    /* Interface
     */
    public interface ICar { }
    public interface IBike { }


    /* Tata
     */
    public class TataCar: ICar
    {
        public void Manufacture() { }
    }

    public class TataBike : IBike
    {
        public void Manufacture() { }
    }



    /* Tesla
     */
    public class TeslaCar : ICar
    {
        public void Manufacture() { }
    }

    public class TeslaBike : IBike
    {
        public void Manufacture() { }
    }



    
    /* This is abstract factory which will return factory of similar objects
     * example Tata, Tesla, Maruti
    */
    public abstract class VehicleCompany
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }




    /* This is factory of similar object which will actually create the objects
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

}
