using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class Recommendation
    {
        private string _memberUsername;
        private string _coachUsername;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string MemberUsername { get => _memberUsername; set => _memberUsername = value; }
        public string CoachUsername { get => _coachUsername; set => _coachUsername = value; }

        public Recommendation(string memberUsername, string coachUsername)
        {
            _memberUsername = memberUsername;
            _coachUsername = coachUsername;
        }

        public static ArrayList ViewAll()
        {
            ArrayList recs = new ArrayList();
            conn.Open();

            SqlCommand viewAll;
            viewAll = new SqlCommand("SELECT memberUsername FROM recommendations", conn);
            SqlDataReader rd = viewAll.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    recs.Add(rd.GetString(0));
                }
                catch
                {
                    continue;
                }
            }
            conn.Close();
            return recs;
        }
    }
}
