using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Data;

namespace ApolloGoldStars
{
    public class Connection : IDisposable
    {
        private TelnetConnection? telnet;
        private bool disposedValue;
        public static string sCardName = "";

        public Connection(string host, int port, int slot, bool is9901, string username, string passw)
        {
            telnet = new TelnetConnection(host, port);
            telnet.Login(username, passw, 100);
            if(GoToDbg())
            {
                telnet.WriteLine("");
                string s = telnet.Read();
                System.Text.RegularExpressions.Regex CapitalLetter = new System.Text.RegularExpressions.Regex(@"\p{Lu}");
                System.Text.RegularExpressions.Match match = CapitalLetter.Match(s);
                if (match.Success)
                {
                    Connection.sCardName = s.Substring(match.Index);
                    Connection.sCardName = sCardName.Substring(0, sCardName.IndexOf(" "));
                }
            }
            OutFromDbg();
        }

        public void OutFromDbg()
        {
            telnet.WriteLine("exit");
            System.Threading.Thread.Sleep(1000);
        }

        public bool GoToDbg()
        {
            telnet.WriteLine("dbg");
            string s = telnet.Read();
            if (s.IndexOf(">") == -1)
            {
                System.Threading.Thread.Sleep(1000);
                telnet.WriteLine("dbg");
                s = telnet.Read();
                if (s.IndexOf(">") != -1)
                {                
                    return true;
                }
                else
                {
                    MessageBox.Show("dbg Connection failed");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        ~Connection()
        {
            Dispose(false);
        }

        public string LogShow()
        {
            if (GoToDbg())
            {
                string sOutPut = "*************logshow*************";
                telnet.WriteLine("logshow");
                string s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                sOutPut += s;
                OutFromDbg();
                return sOutPut;            
            }
            else
            {
                return "";
            }
        }

        public string AlaramAll(bool bIsClearhis)
        {
            if (GoToDbg())
            {
                string sOutPut = "*************almall*************";
                if (bIsClearhis)
                {
                    telnet.WriteLine("clearhis all");
                    System.Threading.Thread.Sleep(1000);

                }
                telnet.WriteLine("almall");
                string s = telnet.Read();
                s = s.Replace("\0","");
                s = s.Substring(s.IndexOf("\n"));
                sOutPut += s;
                OutFromDbg();
                return sOutPut;
            }
            else
            {
                return "";
            }
        }

        public string AlaramPortList(bool bIsClearhis,List<string> ports)
        {
            if (GoToDbg())
            {
                if (bIsClearhis)
                {
                    telnet.WriteLine("clearhis all");
                    System.Threading.Thread.Sleep(1000);

                }
                string sPortOutput = ""; 
                foreach (string port in ports)
                {
                    sPortOutput += "*************showalarms port " + port+ "*************";
                    telnet.WriteLine("showalarms port " + port);
                    sPortOutput += telnet.Read();
                    System.Threading.Thread.Sleep(100);
                }

                OutFromDbg();
                return sPortOutput;
            }
            else
            {
                return "";
            }
        }

        public string Pmdisp(string sUserInput)
        {
            if (GoToDbg())
            {
                telnet.WriteLine("pmdisp "+sUserInput);
                string s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                OutFromDbg();
                return s;
            }
            else
            {
                return "";
            }
        }

        public string Bitdisp(string sUserInput)
        {
            if (GoToDbg())
            {
                telnet.WriteLine("bitdisp " + sUserInput);
                string s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                OutFromDbg();
                return s;
            }
            else
            {
                return "";
            }
        }

        public string UserDbgCommands(List<string> listDbgCommands)
        {
            if (GoToDbg())
            {
                string s = "";
                string sOutput = "";
                foreach (string cmd in listDbgCommands)
                {
                    sOutput += "*************"+cmd+"*************";
                    telnet.WriteLine(cmd);
                    s = telnet.Read();
                    s = s.Replace("\0", "");
                    s = s.Substring(s.IndexOf("\n"));

                    sOutput += s;
                    System.Threading.Thread.Sleep(1000);
                }
                OutFromDbg();
                return sOutput;
            }
            else
            {
                return "";
            }
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

        public string PeriodicAct(int sec)
        {
            string sOutput = "";

            if (GoToDbg())
            {
                telnet.WriteLine("ClearTimeCollection");
                System.Threading.Thread.Sleep(100);
                telnet.WriteLine("SetTickTimeCollection 1");
                telnet.Read();
                for (int i = 0; i < sec; i++)
                {
                    System.Threading.Thread.Sleep(1200); // sec
                    telnet.WriteLine("PeractStat");
                    string s = telnet.Read();
                    s = s.Replace("\0", "");
                    s = s.Substring(s.IndexOf("\n"));
                    sOutput += s;
                }
                telnet.WriteLine("ClearTimeCollection");
                OutFromDbg();
            }

            return sOutput;
        }

        public void HighObjConsumption(int thresholdTime, DataGridView dataGridView1, System.ComponentModel.BackgroundWorker background)
        {

            if (GoToDbg())
            {
                background.ReportProgress(1);
                telnet.WriteLine("SetObjectTimeCollection 1");
                System.Threading.Thread.Sleep(100);
                telnet.WriteLine("SetMinConsumptionTime " + thresholdTime);
                System.Threading.Thread.Sleep(100);
                telnet.WriteLine("InitTimeConsumption");
                System.Threading.Thread.Sleep(100);
                telnet.WriteLine("SetTimeConsumptionFlag 1");
                System.Threading.Thread.Sleep(2000);
                telnet.WriteLine("PrintTimeConsumption 0");

                //background.ReportProgress(20);

                string s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));

                System.Threading.Thread.Sleep(100);
                telnet.WriteLine("ClearTimeCollection");
                //telnet.WriteLine("SetObjectTimeCollection 0");
                OutFromDbg();
                string[] sSplit = s.Split("Time Consumption for");
                Dictionary<string,objData> dictionary = new Dictionary<string, objData>();
                for(int i = 1;i<sSplit.Length;++i)
                {
                    string sFisrSub = sSplit[i].Substring(sSplit[i].IndexOf("time = ") + 7);

                    int time = Convert.ToInt32(sFisrSub.Substring(0, sFisrSub.IndexOf("\r\n")));

                    string key = sSplit[i].Substring(0, sSplit[i].IndexOf("TickActivationNum")).Trim().Replace("\r\n", " ");
                    objData obj = new objData(key);
                    if (!dictionary.ContainsKey(obj.GetKey()))
                    {
                        dictionary.Add(obj.GetKey(),obj);
                    }
                    dictionary[obj.GetKey()].m_Values.Add(time);
                    background.ReportProgress((i * 100)/ sSplit.Length);
                }

                Dictionary<int,string> classIdToClassNameDic = new Dictionary<int,string>();

                foreach (string key in dictionary.Keys)
                {
                    if (!classIdToClassNameDic.ContainsKey(dictionary[key].m_ClassID))
                    {
                        classIdToClassNameDic[dictionary[key].m_ClassID] = GetClassName(dictionary[key].m_ClassID);
                    }
                }

                //dictionary.Sort

                foreach (string key in dictionary.Keys)
                {

                    dataGridView1.Rows.Add(new object[] {classIdToClassNameDic[dictionary[key].m_ClassID],
                                              dictionary[key].m_ClassID.ToString(),
                                              dictionary[key].m_InstanceId,
                                              dictionary[key].m_Priority == 1 ? "foreground" : dictionary[key].m_Priority == 50 ? "background" : "one sec",
                                              dictionary[key].GetMaxTime(),
                                              String.Format("{0:0.##}", dictionary[key].GetAvgTime()),
                                              dictionary[key].m_Values.Count()/2});
                }
            }
        }

        private string GetClassName(int nClassId)
        {
            if (GoToDbg())
            {
                telnet.WriteLine("PfClassInfo " + nClassId);
                System.Threading.Thread.Sleep(100);
                string s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                string sClasName = s.Substring(s.IndexOf("Id5_Format") + 10, s.LastIndexOf(nClassId.ToString()) - (s.IndexOf("Id5_Format") + 10)).Trim();
                OutFromDbg();
                return sClasName;

            }
            else
            {
                return "";
            }
        }
    }

}
