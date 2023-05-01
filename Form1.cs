using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioVerifica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contTick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(contTick == 10)
            {
                DateTime data = DateTime.Now;
                lbl.Text = string.Format("{0}:{1}:{2}", data.Hour, data.Minute, data.Second);
                contTick = 0;
                int add;
                if(int.TryParse(txt.Text, out add)) {
                    data = data.AddHours(add);
                }
                lbl2.Text = string.Format("{0}:{1}:{2}", data.Hour, data.Minute, data.Second); 
            }
            contTick++;
        }
    }
}
