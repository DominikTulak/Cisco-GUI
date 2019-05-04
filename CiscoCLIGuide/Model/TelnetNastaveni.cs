using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CiscoCLIGuide.Model
{
    /*
     * Třída pro nastavení parametrů Telnetu
     */ 
    public static class TelnetNastaveni
    {
        //Adresa připojení
        public static IPAddress adresaTelnetu = null;

        //Port (výchozí 23)
        public static int cisloPortu = 23;
    }
}
