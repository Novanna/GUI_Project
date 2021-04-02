using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aquaGauge1_Load(object sender, EventArgs e)
        {

        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //isi combobox1
            comboBox1.Items.Add("Course");
            comboBox1.Items.Add("Practice");
            comboBox1.Items.Add("Talk Show");
            //isicombobox2
            comboBox2.Items.Add("< 30 Student");
            comboBox2.Items.Add("> 30 Student");
            comboBox2.Items.Add("more than 100 Student");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = !(timer1.Enabled);
            timer2.Enabled = !(timer2.Enabled);
            if (timer1.Enabled && timer2.Enabled == true)
                    simpleButton1.Text = "Stop";
            
            else
                    simpleButton1.Text = "Process";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double temp = 23*time;
            textBox4.Text = Convert.ToString(temp) + "°C";
            double Pres = 101*time;
            textBox5.Text = Convert.ToString(Pres) + "KPa";
            double Hum = 55*time;
            textBox6.Text = Convert.ToString(Hum) + "% RH";
            time += 0.01;

            linearScaleLevelComponent1.Scale.Value = Convert.ToInt32(temp);
            arcScaleNeedleComponent1.Scale.Value = Convert.ToInt32(Pres);
            arcScaleNeedleComponent4.Scale.Value = Convert.ToInt32(Hum);
            
        }
        private double time = 1.0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            double batt = 90 - time;
            digitalGauge1.Text = Convert.ToString(batt);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string result;
            string acara;
            acara = comboBox1.Text;

            result = "Environmental conditions suitable for ";
            MessageBox.Show(result+acara);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            checkedListBox1.ResetText();
            checkedListBox2.ResetText();
            checkedListBox3.ResetText();
        }
    }
}
