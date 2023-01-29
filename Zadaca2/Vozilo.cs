using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Vozilo
    {
        public enum Type { Car, Van, Bus, Truck }
        private Type type;
        private int fare;
        private int batterySize;
        private int gasSize;

        public Vozilo(Type type, int gasSize, int batterySize)
        {
            this.type = type;
            this.gasSize = gasSize;
            this.batterySize = batterySize;

            switch (type)
            {
                case Type.Car:
                    fare = Const.CAR_PRICE;
                    break;
                case Type.Van:
                    fare = Const.VAN_PRICE;
                    break;
                case Type.Bus:
                    fare = Const.BUS_PRICE;
                    break;
                case Type.Truck:
                    fare = Const.TRUCK_PRICE;
                    break;
                default:
                    fare = Const.ZERO;
                    break;
            }
        }


        public int GetFare() => fare;
        public double GetGasSize() => gasSize;
        public double GetBatterySize() => batterySize;
        public Type GetSizeType() => type;

        public void SetGasSize() => gasSize = Const.SIZE_HIGH;
        public void SetBatterySize() => batterySize = Const.SIZE_HIGH;


    }
}
