using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloGoldStars
{
    internal class objData
    {
        public int m_ID { get; set; }
        public string m_Name { get; set;}
        public string m_IntanceName { get; set; }
        public int m_Priority { get; set; }
        public List<int> m_Values { get; set; } = new List<int>();
        public string GetKey()
        {
            return m_ID.ToString() + m_Name + m_Priority.ToString();
        }
        
        public objData(string s)
        {
            m_ID = Convert.ToInt32(s.Substring(0,s.IndexOf(": ")));
            m_Priority = Convert.ToInt32(s.Substring(s.IndexOf(" Priority ") + 10));
            m_Name = s.Substring(s.IndexOf(": ") + 2, s.IndexOf(" Priority ") - (s.IndexOf(": ") + 2));
        }
    }
}
