using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Zaposlenik
    {
        private string name;
        private double salary;
        private double earnings;

        public Zaposlenik(string name, double salary)
        {
            this.name = name;
            this.earnings = 0.0;
            this.salary = salary;
        }

        public void CheckVehicle(Vozilo Vozilo, Vlak Vlak)
        {
            if (Vlak.GetCapacity() > 0)
            {
                Vlak.SetCapacity();
                earnings += Vozilo.GetFare() * salary;

                if (Vozilo.GetGasSize() < Const.SIZE_LOW)
                {
                    Console.WriteLine(name + " " + Vozilo.GetSizeType().ToString() + " velicina je " + Vozilo.GetGasSize() + "% puna");
                    Console.WriteLine("Tankam");
                    Vozilo.SetGasSize();
                    Console.WriteLine(name + "' " + Vozilo.GetSizeType().ToString() + " velicina je " + Vozilo.GetGasSize() + "% puna");
                }

                if (Vozilo.GetBatterySize() < Const.SIZE_LOW)
                {
                    Console.WriteLine(name + " " + Vozilo.GetSizeType().ToString() + " baterija je  " + Vozilo.GetBatterySize() + "% puna");
                    Console.WriteLine("Punim");
                    Vozilo.SetBatterySize();
                    Console.WriteLine(name + " " + Vozilo.GetSizeType().ToString() + " baterija je " + Vozilo.GetBatterySize() + "% puna");

                }
            }
        }


        public string GetName() => name;
        public void GetEarnings() =>
            Console.WriteLine(name + "Zarada je" + earnings);
    }
}
