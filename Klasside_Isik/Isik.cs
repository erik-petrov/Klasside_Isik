using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Klasside_Isik
{
    abstract class Isik
    {
        public enum sugu { M, F };

        public string Nimi;
        public DateTime Synnipaev;
        public sugu Sugu;

        public Isik(string nimi, DateTime synnipaev, sugu sugu)
        {
            Nimi = nimi;
            Synnipaev = synnipaev;
            Sugu = sugu;
        }

        public abstract void MuudaNimi(string newname);
        public abstract int ArvutaVanus();
        public abstract void PrintInfo();
        public abstract double ArvutaSissetulek(double maksuvaba, double tulumaks);
        public abstract void PrintBirthday(); //own

    }
}
