using System.Text;
using System.Net.Sockets;
using System.Net;


namespace ApolloGoldStars
{
    public class Connection
    {
        private Socket _socket;
        private TelnetConnection telnet;

        public Connection(string host, int port, int slot, bool is9901, string username, string passw)
        {
            telnet = new TelnetConnection(host, port);
            telnet.Login(username, passw, 100);
        }
    }
        /*
        public enum Protocol
        {
            Telnet,
            SSH,
            NUM_OF_PROTOCOLS
        }
        public class Connection
        {
            private TcpClient m_tcpSocket;
            private int m_timeoutMs = 100;
            private int m_slot;
            private bool m_is9901 = false;
            private Protocol m_protocol = Protocol.Telnet;

            public string? m_username { get; set;}
            public string? m_password { get; set;}

            public Connection(string host, int port, int slot, bool is9901, Protocol protocol)
            {
                m_tcpSocket = new TcpClient(host, port);
                m_protocol = protocol;
                m_slot = slot;
                m_is9901 = is9901;
            }

        }
        */

    }
