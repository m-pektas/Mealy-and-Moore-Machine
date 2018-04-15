using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moore_And_Mealy_Makiesi
{
    public partial class Hello : Form
    {
        public static Form frmMoore;
        public static Form frmMealy;

        public Hello()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            frmMoore = new Moore();
            frmMoore.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMealy = new Mealy();
            frmMealy.Show();
            this.Hide();
        }
    }
}
