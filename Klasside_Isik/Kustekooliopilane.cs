using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Klasside_Isik.Isik;

namespace Klasside_Isik
{
    internal class Kustekooliopilane : Isik
    {
        public enum Spec { TAR, LOG, LOGIT, MEH }
        public enum Course { Esimene, Teine, Kolmas }

        public string Oppeasutus;
        public Spec Eriala;
        public Course Kursus;
        public double Toetus;

        public Kustekooliopilane(string nimi, DateTime synnipaev, sugu sugu, string oppeasutus,
            Spec eriala, Course kursus, double toetus) : base(nimi, synnipaev, sugu)
        {
            Oppeasutus = oppeasutus;
            Eriala = eriala;
            Kursus = kursus;
            Toetus = toetus;
        }

        public override int ArvutaVanus() { return DateTime.Now.Year - Synnipaev.Year; }

        public override void MuudaNimi(string newname) { Nimi = newname; }

        public override void PrintInfo()
        {
            Console.WriteLine(
                $"Õpilane: \n" +
                $"Nimi: {Nimi}\n" +
                $"Sünnipäev: {Synnipaev.ToString("MM/dd/yyyy")}\n" +
                $"Sugu: {Sugu}\n" +
                $"Kooli nimi: {Oppeasutus}\n" +
                $"Eriala: {Eriala}\n" +
                $"Kursus: {Kursus}\n" +
                $"Toetus: {Toetus}"
                );
        }

        public override void PrintBirthday() { Console.WriteLine(Synnipaev.ToString("dd/MM/yyyy")); }

        public override double ArvutaSissetulek(double maksuvaba, double tulumaks) { return Toetus; }

        public void MuudaEriala(Spec New) { Eriala = New; Kursus = Kustekooliopilane.Course.Esimene; }
    }
}
