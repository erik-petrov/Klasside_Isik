using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_Isik
{
    internal class Tootaja : Isik
    {
        public enum Amets { Teacher, Developer, Manager, Janitor }

        public string Asutus;
        public Amets Amet;
        public double Tootasu;
        public Tootaja(string nimi, DateTime synnipaev, sugu sugu, Amets amet, double tootasu, string asutus) : base(nimi, synnipaev, sugu)
        {
            Amet = amet;
            Tootasu = tootasu;
            Asutus = asutus;
        }

        public override int ArvutaVanus() { return DateTime.Now.Year - Synnipaev.Year; }

        public override void MuudaNimi(string newname) { Nimi = newname; }

        public override void PrintInfo()
        {
            Console.WriteLine(
                $"Tootaja: \n" +
                $"Nimi: {Nimi}\n" +
                $"Sünnipäev: {Synnipaev.ToString("MM/dd/yyyy")}\n" +
                $"Sugu: {Sugu}\n" +
                $"Amet: {Amet}\n" +
                $"Asutus: {Asutus}\n" +
                $"Töötasu: {Tootasu}"
                );
        }

        public override double ArvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double net = Tootasu;
            if (Tootasu > 2499.0)
                maksuvaba = 0.0;
            if (Tootasu >= 1200.0 && Tootasu <= 2100.0)
            {
                maksuvaba = 500 - (500.0 / 900.0 * (Tootasu - 1200.0));
            }
            
            double whateverthisis = Tootasu * 0.016;
            double pension = Tootasu * 0.02;
            net -= (pension + whateverthisis);
            double disaster = (net - maksuvaba) * tulumaks;
            net -= disaster;
            return Math.Round(net, 2);
        }

        public override void PrintBirthday()
        {
            Console.WriteLine(Synnipaev.ToString("dd/MM/yyyy"));
        }

        public void ChangeProfession(Amets New) { Amet = New;  }
    }
}
