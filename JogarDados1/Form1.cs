using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogarDados1
{
    public partial class Form1 : Form
    {
        public List<string> dado6 = new List<string>();
        public List<string> dado10 = new List<string>();
        public List<string> dado20 = new List<string>();
        public List<string> dado100 = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string result = "";
            string qualDado = "";
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                    {
                        result = Dado.Rolar(int.Parse(rb.Text));
                        qualDado = rb.Text;
                    }

            }
                 
            switch(qualDado)
            {
                case "6":                    
                    dado6.Add(result + " ---- " + DateTime.Now);
                    dado6.Reverse();
                    listBox6.DataSource = null;
                    listBox6.DataSource = dado6;
                    dado6.Reverse();
                    break;
                case "10":
                    dado10.Add(result + " ---- " + DateTime.Now);
                    dado10.Reverse();
                    listBox10.DataSource = null;
                    listBox10.DataSource = dado10;
                    dado10.Reverse();
                    break;
                case "20":
                    dado20.Add(result + " ---- " + DateTime.Now);
                    dado20.Reverse();
                    listBox20.DataSource = null;
                    listBox20.DataSource = dado20;
                    dado20.Reverse();
                    break;
                case "100":
                    dado100.Add(result + " ---- " + DateTime.Now);
                    dado100.Reverse();
                    listBox100.DataSource = null;
                    listBox100.DataSource = dado100;
                    dado100.Reverse();
                    break;


            }
                
             


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
