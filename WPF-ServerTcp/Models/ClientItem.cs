using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ServerTcp.Models
{
    public class ClientItem
    {
        public TcpClient Client { get; set; }

        public string Name { get; set; }

    }
}
