using System.Text;
using System.Net.Sockets;
using System.Net;


namespace ApolloGoldStars
{
    public class Connection : IDisposable
    {
        private TelnetConnection telnet;
        private bool disposedValue;

        public Connection(string host, int port, int slot, bool is9901, string username, string passw)
        {
            telnet = new TelnetConnection(host, port);
            telnet.Login(username, passw, 100);
        }

        ~Connection()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (telnet != null)
                {
                    ((IDisposable)telnet).Dispose();
                    telnet = null;
                }
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Connection()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
