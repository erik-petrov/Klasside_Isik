using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Klasside_Isik.Isik;
using static Klasside_Isik.Tootaja;

namespace Klasside_Isik
{
    internal class Opilane : Isik
    {
        public enum spec { KeemiaMatemaatika, Humanitaarne }

        public string KooliNimi;
        public spec Spetsialiseerumine;
        public string Klass;

        public Opilane(string nimi, DateTime synnipaev, sugu sugu, spec spetsialiseerumine, string klass, string koolinimi) : base(nimi, synnipaev, sugu)
        {
            Spetsialiseerumine = spetsialiseerumine;
            Klass = klass;
            KooliNimi = koolinimi;
        }

        public override int ArvutaVanus() { return DateTime.Now.Year - Synnipaev.Year; }

        public override void MuudaNimi(string newname) { Nimi = newname; }

        public override void PrintInfo()
        {
            Console.WriteLine(
                $"Õpilane: \n" +
                $"Nimi: {Nimi}\n" +
                $"Sünnipäev: {Synnipaev.ToString("dd/MM/yyyy")}\n" +
                $"Sugu: {Sugu}\n" +
                $"Kooli nimi: {KooliNimi}\n" +
                $"Spetsialiseerumine: {Spetsialiseerumine}\n" +
                $"Klass: {Klass}"
                );
        }

        public override void PrintBirthday(){ Console.WriteLine(Synnipaev.ToString("dd/MM/yyyy")); }

        public override double ArvutaSissetulek(double maksuvaba, double tulumaks) { return 0.0;  }
    }
}
