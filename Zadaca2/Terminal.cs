using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Terminal
    {
        private Vlak smallTrain;
        private Vlak largeTrain;
        private int ticketEarnings = Const.ZERO;

        public Terminal(Vlak.Size trainSize)
        {
            if (trainSize == Vlak.Size.Small)
                smallTrain = new Vlak(trainSize);
            else
                largeTrain = new Vlak(trainSize);
        }

        public void ParkVehicle(Vozilo Vozilo, Zaposlenik Zaposlenik)
        {
            if (Vozilo.GetSizeType() == Vozilo.Type.Car || Vozilo.GetSizeType() == Vozilo.Type.Van)
                Zaposlenik.CheckVehicle(Vozilo, smallTrain);

            else
                Zaposlenik.CheckVehicle(Vozilo, largeTrain);

            ticketEarnings += Vozilo.GetFare();
            Console.WriteLine();
        }

        public void GetTicketEarnings() => Console.WriteLine("Ukupna zarada" + ticketEarnings);


    }
}
