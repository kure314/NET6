using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ns_UserInfo.UserInfo Uzivatel = ns_UserInfo.UserInfo.NovyUzivatelzKarty("3456113395");

            Application.Run(new Form1(Uzivatel));
        }
    }
}
