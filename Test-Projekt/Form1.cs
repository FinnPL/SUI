using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Projekt
{
    public partial class Form1 : Form
    {
        String x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            DialogResult dr = MessageBox.Show("SUI?", "Bist du ein Süer?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sui.wav");
                player.Play();
                DialogResult s = MessageBox.Show("SUI", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
              
                while ( s == DialogResult.OK)
                {
                    player.Play();
                    s = MessageBox.Show("SUI", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    
                }
                
               
                
            } else {
                this.Close();    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void auth_Click(object sender, EventArgs e)
        {
            if (x == "sui")
            {
                button2.Enabled = true;
                MessageBox.Show("SUI", "Auth richtig");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         x=textBox1.Text;
            
        }
    }
}
