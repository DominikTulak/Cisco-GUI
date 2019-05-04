using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoCLIGuide.Model.Cisco
{
    static class Interface
    {
        public static List<string> ipAddress(string interf)
        {
            var output = new List<string>();
            output.Add("end");
            output.Add("configure terminal");
            output.Add(String.Format("interface {0}{1}", Model.NastaveniStroju.RouterInterface.druhInterfacu, Model.NastaveniStroju.RouterInterface.oznaceniInterfacu));
            output.Add(String.Format("ip address {0} {1}", Model.NastaveniStroju.RouterInterface.IPAdresaInterfacu, Model.NastaveniStroju.RouterInterface.MaskaInterfacu));
            return output;
        }
    }
}
