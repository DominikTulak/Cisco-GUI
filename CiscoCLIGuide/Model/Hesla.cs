using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIGuide.Model
{
    /*
     * Třída s informacemi o požadavcích na hesla a jejich znění
     */ 
    public static class Hesla
    {
        //Nastavení požadavků na hesla
        public static bool hesloKonzole = false;
        public static bool hesloTelnet = false;
        public static bool hesloEXEC = false;

        //Přesné znění hesel (plaintext :))
        public static string hesloKonzoleString = "";
        public static string hesloTelnetString = "";
        public static string hesloEXECString = "";
    }
}
