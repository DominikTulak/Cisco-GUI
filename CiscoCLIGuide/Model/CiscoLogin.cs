using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIGuide.Model
{
    class CiscoLogin
    {
        private static string init(bool zkracene = false) {    //Přihlášení se do čistě vymazaného zařízení
            string vystup = "";
            //vystup = $"
            //no
            //en
            //...
            //"

            return vystup;

        }

        private static string login(bool zkracene = false) {    //Přihlášení se do již nastaveného zařízení
            string vystup = "";
            //if(password) {
            //  login(input od uzivatele1
            //
            //}
            //en
            return vystup;
        }
        private static string Interface(string interfaceName, bool zkracene = false) { //Tměna interfacu na interfaceName
            string vystup = "";
            //en
            //Interface interfaceName
            //...
            return vystup;
        }
        public static string Login(string vstup, bool zkracene = false)
        {
            string vystup = "";
            //if(vstup == "Press RETURN to get started!") {
                //this.init()  
            //}
            //else {
                //this.login(AskForPass) //AskForPass = metoda, žádající uživatele o heslo
            //}
            return vystup;
        }
        private static string UnkwownInput(string vstup) {
            string vystup = "";
            vystup += "!##############################";
            vystup += "!Zaznamenán neznámů výstup!\n!\n!";
            vystup += vstup;
            vystup += "!\n!\n!##############################";
            return vystup;
        }

    }
}
