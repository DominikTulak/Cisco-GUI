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
using System.Diagnostics;

namespace CiscoCLIGuide.Model
{

    class TelnetTest
    {
        public static void Telnet(TextBox tb) {
            TcpClient client = new TcpClient("google.com", 23);
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            string data = sr.ReadLine();
            while (data != null)
            {
                tb.Text += "\n" + data;
                MessageBox.Show(data);
                sw.WriteLine("aaa");
                data = sr.ReadLine();

            }
            
            client.Close();
            
        }
        
    }
}
