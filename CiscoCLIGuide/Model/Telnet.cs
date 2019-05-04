using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimS.Telnet;

namespace CiscoCLIGuide.Model
{
     class Telnet
    {
        public string lastRead;
        public Client telnet;

        public string Read()
        {
            read();
            return lastRead;
        }
        public void Write(string command)
        {
            telnet.Write(command);
        }
        public void WriteLine(string command)
        {
            telnet.WriteLine(command);
        }
        private async Task read()
        {
            lastRead = await telnet.ReadAsync();
        }

        public Telnet(string ip, int port = 23)
        {
            telnet = new Client(ip, port, new System.Threading.CancellationToken());
        }
    }
}
