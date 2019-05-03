using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIGuide.Model
{
    /*
     * Třída reprezentující aktuální nastavení sériové linky
     */ 
    public static class RS232
    {
        //Číslo portu
        public static int cisloPortu = 1;

        //Baudová rychlost
        public static int baudovaRychlost = 9600;

        //Data bity
        public static int pocetDataBitu = 8;

        //Stop bity
        //false = 1, true = 2
        public static bool pocetStopBitu = false;

        //Parita
        public static Parita parita = Parita.ZADNA;
    }

    //Možnosti parity
    public enum Parita
    {
        SUDA = 1,
        LICHA = 2,
        ZADNA = 3
    }
}
