using ns_UserInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        UserInfo Uzivatel;
   
        public Form1(UserInfo Uzivatel)
        {
            InitializeComponent();
            //binding1 = new BindingSource(Uzivatel, "Uzivatel");
            this.Uzivatel = Uzivatel;
            textBox1.DataBindings.Add("Text", Uzivatel, "_name", false, DataSourceUpdateMode.OnPropertyChanged);
            //textBox1.DataBindings.Add("Text", Uzivatel, "_name", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Uzivatel.celeJmeno;
        }
    }
}
