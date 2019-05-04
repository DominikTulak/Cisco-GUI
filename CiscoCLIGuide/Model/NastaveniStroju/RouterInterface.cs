using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CiscoCLIGuide.Model.NastaveniStroju
{
    /*
     * Třída pro nastavení interfacu routeru
     */ 
    public static class RouterInterface
    {
        //Druh interfacu
        public static string druhInterfacu = "";

        //Označení interfacu
        public static string oznaceniInterfacu = "";

        //Povolit interface?
        public static bool povolitInterface = false;

        //IP adresa interfacu
        public static IPAddress IPAdresaInterfacu = null;

        //Maska interfacu
        public static IPAddress MaskaInterfacu = null;

        //Description interfacu
        public static string DescriptionInterfacu = "";
    }
}
