using Solid.Model;
using Solid.QA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminalSmallTrain = new Terminal(Vlak.Size.Small);
            Terminal terminalLargeTrain = new Terminal(Vlak.Size.Large);

            Zaposlenik employeeSmallTrain = new Zaposlenik("Marac", 0.1);
            Zaposlenik employeeLargeTrain = new Zaposlenik("MagnusCArlsen", 0.21);


            Vozilo car = new Vozilo(Vozilo.Type.Car, 50, 5);
            Vozilo van = new Vozilo(Vozilo.Type.Car, 8, 20);
            Vozilo bus = new Vozilo(Vozilo.Type.Bus, 20, 30);
            Vozilo truck = new Vozilo(Vozilo.Type.Truck, 5, 60);

            terminalSmallTrain.ParkVehicle(car, employeeSmallTrain);
            terminalSmallTrain.ParkVehicle(van, employeeSmallTrain);
            terminalLargeTrain.ParkVehicle(bus, employeeLargeTrain);
            terminalLargeTrain.ParkVehicle(truck, employeeLargeTrain);

            terminalSmallTrain.GetTicketEarnings();
            terminalLargeTrain.GetTicketEarnings();

            Console.WriteLine();

            employeeSmallTrain.GetEarnings();
            employeeLargeTrain.GetEarnings();

            Console.WriteLine();

            Test test = new Test();
            test.TestTrainSize();
        }
    }
}
