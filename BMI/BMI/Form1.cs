using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnCompute.Click += btnCompute_Click;
        }

        void btnCompute_Click(object sender, EventArgs e)
        {
            double height = double.Parse(this.txtHeight.Text);
            double weight = double.Parse(this.txtWeight.Text);
            double bmi = weight / (Math.Pow(height/100, 2));
            if (bmi < 18.5)
            {
                this.txtResult.Text = String.Format("{0:0.##}", bmi) + " (ban thieu can)";
            }
            else if (bmi >= 18.5 || bmi <= 24.9)
            {
                this.txtResult.Text = String.Format("{0:0.##}", bmi) + " (binh thuong)";
            }
            else 
            {
                this.txtResult.Text = String.Format("{0:0.##}", bmi) + " (thua can)";
            }
        }
    }
}
