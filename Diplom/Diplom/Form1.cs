using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Diplom
{
    public partial class Form1 : Form

    {
        Logic logic;
        //string values;
        public Form1()
        {
            InitializeComponent();
            logic = new Logic();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = true;
            //string answer = combobox1.selectedindex.tostring();
            //logic.setanswer(answer);
            //logic.setallparametrsmicro(0, combobox1.selectedindex);
            //logic.setallparametrsmicro(1, combobox2.selectedindex);
            //logic.setallparametrsmicro(2, combobox3.selectedindex);
            //logic.setallparametrsmicro(3, combobox4.selectedindex);
            //label3.text = " " + logic.settextlabel();
            
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
