using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace CiscoCLIGuide.Model.NastaveniStroju
{
    public static class KontrolaMasky
    {
        public static bool VytvorMasku(string vstup, out IPAddress maska)
        {
            //KONTROLA FORMÁTU
            //Formát 1 - s lomítkem
            if (vstup[0] == '/')
            {
                //Odstranění lomítka
                string hodnotaMasky = vstup.Substring(1);
                int hodnotaMaskyCislo = 0;

                //Kontrola, zda následuje číslo
                if (int.TryParse(hodnotaMasky, out hodnotaMaskyCislo) == false || hodnotaMaskyCislo == 0)
                {
                    maska = null;
                    return false;
                }
                else
                {
                    MessageBox.Show(SectiRekurzivne(hodnotaMaskyCislo).ToString());
                    maska = new IPAddress(BitConverter.GetBytes(SectiRekurzivne(hodnotaMaskyCislo)));
                    return true;
                }
            }
            //Formát 1 - dot decimal
            else
            {
                IPAddress vystup = null;
                bool vysledek2 = IPAddress.TryParse(vstup, out vystup);

                if (vysledek2 == false) //Převod se nezdařil
                {
                    maska = null;
                    return false;
                }

                maska = vystup;
                return true;
            }
        }

        //Metoda pro součet druhých mocnin od 0 až do vstup-1
        private static int SectiRekurzivne (int vstup)
        {
            int vystup = 0;
            for (int i = 0; i < vstup; i++)
            {
                vystup = vystup + (int)Math.Pow(2, i);
            }
            return vystup;
        }
    }
}
