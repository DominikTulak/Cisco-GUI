using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Forms;

namespace CiscoCLIGuide.Model
{

    class TelnetTest
    {
        public static void Telnet(TextBox tb) {
            TcpClient client = new TcpClient("tulak.host", 52556);
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            string data = sr.ReadLine();
            while (data != null)
            {
                tb.Text += "\n" + data;
                data = sr.ReadLine();
            }
            client.Close();
        }
        
    }
}
