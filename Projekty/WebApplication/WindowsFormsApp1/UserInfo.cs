
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ns_UserInfo
{
    public class UserInfo
    {
        //private const string conn = "Data Source=10.220.135.95;Initial Catalog=KURE;User ID=kv_log;Connection Timeout = 5;Password=vertex1*";
        private const string conn = "Data Source=10.220.158.233;Initial Catalog=UDRZBA;User ID=kv_log;Connection Timeout = 5;Password=vertex1*";
        public List<string> data = new List<string> { "", "", "", "", "", "", "", "", "" };
        public string _karta { get { return (data[0]); } set { data[0] = value; } }
        public string _SGID { get { return (data[1]); } set { data[1] = value; } }
        public string _OC8 { get { return (data[2]); } set { data[2] = value; } }
        public string _name { get { return (data[3]); } set { data[3] = value; } }
        public string _surname { get { return (data[4]); } set { data[4] = value; } }
        public bool isOK { get { return (Convert.ToBoolean(data[5])); } set { data[5] = value.ToString() ; } }
        public string celeJmeno { get { return _name + " " + _surname; } }
        public string _email { get; set; }
        public int _idStredisko { get; set; }
        /// <summary>
        /// Písmeno směny ABCD, K = denní směna
        /// </summary>
        public string _smena { get; set; }
        /// <summary>
        /// Nastavení terminálu je třída přidaná do NoEG Krtka
        /// </summary>
        //public KrtkovyTridy.Terminal NastaveniTerminalu { get; set; } = null;
        public static UserInfo Uzivatel(string KartaNeboSGID)
        {
            UserInfo vysledek = new UserInfo();
            vysledek.isOK = false;
            bool jeSGID = !String.IsNullOrEmpty(KartaNeboSGID) && Char.IsLetter(KartaNeboSGID[0]);
            //string loccon = @" Data Source = 10.220.158.236; Initial Catalog = AktionNEXTSAP; User ID = mes; Password = vertex1*";
            
        SqlConnection pripojeni = new SqlConnection(conn);
            if (jeSGID)
            {
                //string query = "select TOP 1 _oc8,_SGID,_karta,_name,_surname from KURE.dbo.Users with (index(IX_Users_sgid) nolock) where _sgid=@sgid";
                string query = "SELECT TOP 1 oc8 _oc8,SGID _SGID,karta _karta,JmenoKrestni _name, Prijmeni _surname, Email _email, _smena FROM a_User where SGID=@sgid";

                SqlCommand prikaz = new SqlCommand(query, pripojeni);
                prikaz.Parameters.AddWithValue("@SGID", KartaNeboSGID);
                try
                {
                    pripojeni.Open();
                    SqlDataReader data = prikaz.ExecuteReader();
                    while (data.Read())
                    {
                        vysledek._OC8 = data["_oc8"].ToString();
                        vysledek._SGID = data["_SGID"].ToString();
                        vysledek._name = data["_name"].ToString();
                        vysledek._surname = data["_surname"].ToString();
                        vysledek._karta = data["_karta"].ToString();
                        vysledek._email = data["_email"].ToString();
                        vysledek._smena = data["_smena"].ToString();
                    }
                    vysledek.isOK = true;
                }
                catch 
                {
                    //System.Diagnostics.EventLog.WriteEntry("_log", rrr.Message);
                    vysledek.isOK = false;
                    vysledek._SGID = KartaNeboSGID;

                }
            }
            else  // je karta
            {
                string query = "SELECT TOP 1 oc8 _oc8,SGID _SGID,karta _karta,JmenoKrestni _name, Prijmeni _surname FROM a_User where karta=@karta";

                SqlCommand prikaz = new SqlCommand(query, pripojeni);
                prikaz.Parameters.AddWithValue("@karta", KartaNeboSGID);
                try
                {
                    pripojeni.Open();
                    SqlDataReader data = prikaz.ExecuteReader();
                    while (data.Read())
                    {
                        vysledek._OC8 = data["_oc8"].ToString();
                        vysledek._SGID = data["_SGID"].ToString();
                        vysledek._name = data["_name"].ToString();
                        vysledek._surname = data["_surname"].ToString();
                        vysledek._karta = data["_karta"].ToString();
                    }
                    vysledek.isOK = true;
                }
                catch 
                {
                    //System.Diagnostics.EventLog.WriteEntry("_log", rrr.Message);
                    vysledek.isOK = false;
                    vysledek._karta = KartaNeboSGID;
                }
            }
            //kotrola, jestli vysledek něco obsahuje
            if (vysledek._OC8=="")
            {
                vysledek.isOK = false;
                vysledek._karta = KartaNeboSGID;
                vysledek._SGID = KartaNeboSGID;

            }
            return vysledek;
        }
        public void Clear()
        {
            _karta = string.Empty;
            _SGID = string.Empty;
            _OC8 = string.Empty;
            _name = string.Empty;
            _surname = string.Empty;
            isOK = false;
        }
 
        public static UserInfo NovyUzivatelzKarty(string karta)
        {
            return NovyUzivatel(karta, 0);
        }
        public static UserInfo NovyUzivatelZeSGIDu(string SGID)
        {
            return NovyUzivatel(SGID, 1);
        }
        public static UserInfo NovyUzivatelzOC8(string OC8)
        {
            return NovyUzivatel(OC8, 2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hodnota">Karta, nebo SGID, nebo OC8</param>
        /// <param name="typ">0-karta, 1-SGID, 2-OC8</param>
        private static UserInfo NovyUzivatel(string hodnota, byte typ)
        {
            UserInfo vysledek = new UserInfo();
            string connString= "Data Source = 10.220.158.233; Initial Catalog = UDRZBA; User ID = kv_log; Connection Timeout = 5; Password =vertex1*";
            string query = "sp_UserInfo";

            SqlConnection pripojeni = new SqlConnection(connString);
            SqlCommand prikaz = new SqlCommand(query, pripojeni);
            prikaz.Parameters.AddWithValue("@VALUE",hodnota);
            prikaz.Parameters.AddWithValue("@TYP", typ);
            prikaz.CommandType = CommandType.StoredProcedure;
            try
            {
                pripojeni.Open();
                SqlDataReader data = prikaz.ExecuteReader();
                while (data.Read())
                {
                    vysledek._name = data["_jmeno"].ToString();
                    vysledek._surname = data["_prijmeni"].ToString();
                    vysledek._SGID = data["_SGID"].ToString();
                    vysledek._OC8 = data["_OC8"].ToString();
                    vysledek._karta = data["_karta"].ToString();
                    vysledek._email = data["_email"].ToString();
                    vysledek._idStredisko = (int)data["_idStredisko"];
                }
                vysledek.isOK = true;
                pripojeni.Close();
            }
            catch (Exception rr)
            {
                Debug.WriteLine(rr.Message);
                //System.Diagnostics.EventLog.WriteEntry("_log", rrr.Message);
                vysledek.isOK = false;
                vysledek._karta = hodnota;
            }
            return vysledek;
        }


        public override string ToString()
        {
            return "Jmeno:" + _name + Environment.NewLine + "Příjmení:" + _surname + Environment.NewLine + "Karta:" + _karta + Environment.NewLine + "SGID:" + _SGID + Environment.NewLine + "OC8:" + _OC8 + Environment.NewLine + "isOK:" + isOK.ToString();
        }
        public System.Data.SqlClient.SqlParameter _SGID_DB { get { return new System.Data.SqlClient.SqlParameter("@SGID",_SGID); } }
        public System.Data.SqlClient.SqlParameter _HOSTNAME_DB { get { return new System.Data.SqlClient.SqlParameter("@HOSTNAME", Environment.MachineName); } }
    }
}
