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
        private int m_Slot;

        public Connection(string host, int port, int slot, bool is9901, string username, string passw)
        {
            telnet = new TelnetConnection(host, port);
            telnet.Login(username, passw, 100);
            if (!is9901)
            {
                telnet.WriteLine("telnet op" + slot.ToString());
                telnet.Login(username, passw, 100);
            }
            m_Slot = slot;
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
            if (s.IndexOf(">") == -1 || s.IndexOf("Please try again") != -1)
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
                    System.Threading.Thread.Sleep(100);
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
            background.ReportProgress(1);
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

                background.ReportProgress(15);

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
                    if (i == (sSplit.Length/2))
                    {
                        background.ReportProgress(50);
                    }
                    
                }
                background.ReportProgress(75);
                Dictionary<int,string> classIdToClassNameDic = new Dictionary<int,string>();

                foreach (string key in dictionary.Keys)
                {
                    if (!classIdToClassNameDic.ContainsKey(dictionary[key].m_ClassID))
                    {
                        classIdToClassNameDic[dictionary[key].m_ClassID] = GetClassName(dictionary[key].m_ClassID);
                    }
                }
                background.ReportProgress(85);
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
                background.ReportProgress(100);
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

        internal void PeractObjs(DataGridView dataGridView1)
        {
            if (GoToDbg())
            {
                telnet.WriteLine("PerActDisp 1");
                System.Threading.Thread.Sleep(1000);

                string s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                s = s.Replace(" ", "");

                string[] sForegroundSplit = s.Split(new Char[] { ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, objData> dictionary = new Dictionary<string, objData>();

                for (int i = 1; i < (sForegroundSplit.Length - 1); i += 2)
                {
                    objData obj = new objData(sForegroundSplit[i + 1], false);

                    if (!dictionary.ContainsKey(obj.GetKey()))
                    {
                        obj.m_ClassName = sForegroundSplit[i];
                        obj.m_IsRegToForeground = true;
                        dictionary.Add(obj.GetKey(), obj);
                    }
                }

                telnet.WriteLine("PerActDisp 50");
                System.Threading.Thread.Sleep(2000); // 2sec

                s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                s = s.Replace(" ", "");

                string[] sBackGroundSplit = s.Split(new Char[] { ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < (sBackGroundSplit.Length - 3); i += 4)
                {
                    objData obj = new objData(sBackGroundSplit[i + 1], false);

                    if (!dictionary.ContainsKey(obj.GetKey()))
                    {
                        obj.m_ClassName = sBackGroundSplit[i];
                        obj.m_IsRegToBackround = true;
                        obj.m_TicksArray[0] = Convert.ToInt32(sBackGroundSplit[i + 2].Replace("onTick#", ""));
                        obj.m_TicksArray[1] = Convert.ToInt32(sBackGroundSplit[i + 3].Replace("onTick#", ""));
                        dictionary.Add(obj.GetKey(), obj);
                    }
                    else
                    {
                        dictionary[obj.GetKey()].m_IsRegToBackround = true;
                        dictionary[obj.GetKey()].m_TicksArray[0] = Convert.ToInt32(sBackGroundSplit[i + 2].Replace("onTick#", ""));
                        dictionary[obj.GetKey()].m_TicksArray[1] = Convert.ToInt32(sBackGroundSplit[i + 3].Replace("onTick#", ""));
                    }
                }

                telnet.WriteLine("PerActDisp 100");
                System.Threading.Thread.Sleep(1000);

                s = telnet.Read();
                s = s.Replace("\0", "");
                s = s.Substring(s.IndexOf("\n"));
                s = s.Replace(" ", "");

                string[] sOneSecSplit = s.Split(new Char[] { ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < (sOneSecSplit.Length - 2); i += 3)
                {
                    objData obj = new objData(sOneSecSplit[i + 1], false);

                    if (!dictionary.ContainsKey(obj.GetKey()))
                    {
                        obj.m_ClassName = sOneSecSplit[i];
                        obj.m_IsRegToOnesec = true;
                        obj.m_TicksArray[0] = Convert.ToInt32(sOneSecSplit[i + 2].Replace("onTick#", ""));
                        dictionary.Add(obj.GetKey(), obj);
                    }
                    else
                    {
                        dictionary[obj.GetKey()].m_IsRegToOnesec = true;
                        dictionary[obj.GetKey()].m_TicksArray[2] = Convert.ToInt32(sOneSecSplit[i + 2].Replace("onTick#", ""));
                    }
                }

                OutFromDbg();

                int rowNum = 0;
                foreach (string key in dictionary.Keys)
                {
                    DataGridViewButtonColumn DelAddButtonColumn = new DataGridViewButtonColumn();
                    DelAddButtonColumn.Name = "ActionColumn";
                    DelAddButtonColumn.Text = "Delete";
                    dataGridView1.Rows.Add(new object[] {dictionary[key].m_ClassName,
                                              dictionary[key].m_ClassID.ToString(),
                                              dictionary[key].m_InstanceId,
                                              dictionary[key].m_IsRegToForeground,
                                              (dictionary[key].m_TicksArray[0] == -1 ? "" : dictionary[key].m_TicksArray[0]) + ", " + (dictionary[key].m_TicksArray[1] == -1 ? "" : dictionary[key].m_TicksArray[1]),
                                              (dictionary[key].m_TicksArray[2] == -1 ? "" : dictionary[key].m_TicksArray[2]),
                                              DelAddButtonColumn
                                              });
                    dataGridView1.Rows[rowNum].Cells[6].Value = "Delete";
                    ++rowNum;
                }
            }
        }

        public void DeleteFromPerAct(string input)
        {
            if (GoToDbg())
            {
                telnet.WriteLine("DelObjFromPerAct " + input);
                OutFromDbg();
            }
        }
        public void AddtoPerAct(string input)
        {
            if (GoToDbg())
            {
                telnet.WriteLine("AddObjForPerAct " + input);
                OutFromDbg();
            }
        }
        
        private bool AllThePartFFFF(string[] a_arr, int a_start, int a_end)
        {
            for (int i = a_start; i <= a_end; ++i)
            {
                if (a_arr[i] != "ffff")
                {
                    return false;
                }
            }
            return true;
        }
        public string ConvertToCorrectFormat(string a_atr)
        {
            int converToNum = 0;
            string converToString = "";
            string res = "";
            string[] words = a_atr.Split(':');
            if (words[2] != "ffff" && true == AllThePartFFFF(words, 3, 8))
            {
                res += "0.";
                converToNum = Convert.ToInt32(words[2]);
                ++converToNum;
                converToString = Convert.ToString(converToNum);
                res += converToString;
            }
            else if (words[8] != "ffff" && true == AllThePartFFFF(words, 2, 7))
            {
                res += "0.";
                converToNum = Convert.ToInt32(words[8]);
                ++converToNum;
                converToString = Convert.ToString(converToNum);
                res += converToString;
            }
            else
            {
                res += "0.";
                converToNum = Convert.ToInt32(words[2]);
                ++converToNum;
                converToString = Convert.ToString(converToNum);
                res += converToString;
                for (int i = 3; i <= 8; ++i)
                {
                    if (words[i] == "ffff")
                    {
                        res += ".0";
                    }
                    else
                    {
                        converToNum = Convert.ToInt32(words[i]);
                        ++converToNum;
                        converToString = Convert.ToString(converToNum);
                        res += '.';
                        res += converToString;
                    }
                }
            }
            return res;
        }
    }
}
