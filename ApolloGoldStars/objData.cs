using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloGoldStars
{
    internal class objData
    {
        public int m_ClassID { get; set; }
        public string m_InstanceId { get; set;}
        public string m_ClassName { get; set; }
        public int m_Priority { get; set; }
        public List<int> m_listPriority { get; set; }
        public List<int> m_Values { get; set; } = new List<int>();

        private bool m_fullKey;
        public string GetKey()
        {
            string key = m_ClassID.ToString() + m_InstanceId;
            if (m_fullKey)
            {
                key += m_Priority.ToString();
            }
            return key;
        }
        
        public objData(string s, bool fullKey = true)
        {
            if (!fullKey)
            {
                m_ClassName = s;
            }
            m_ClassID = Convert.ToInt32(s.Substring(0,s.IndexOf(": ")));
            m_InstanceId = s.Substring(s.IndexOf(": ") + 2, s.IndexOf(" Priority ") - (s.IndexOf(": ") + 2));
            m_Priority = Convert.ToInt32(s.Substring(s.IndexOf(" Priority ") + 10));
            m_fullKey = fullKey;
        }

        public int GetMaxTime()
        {
            return m_Values.Max();
        }

        public double GetAvgTime()
        {
            return m_Values.Average();
        }
    }
}
