using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypt_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            string input = Sendler.Text;
            string AlphabetNumbers = Alghorytm.StrToNumArray(input);
            string ControlSum = Alghorytm.GetControlSum(AlphabetNumbers);
            this.ControlSum.Enabled = true;
            this.ControlSum.Text = "" +  ControlSum.GetHashCode();
            Receiver.Text = Sendler.Text;

            string Numbers = Alghorytm.StrToNumArray(input);
            ControlSum = Alghorytm.GetControlSum(Numbers);
            ControlSum = "" + ControlSum.GetHashCode();
            if (ControlSum == this.ControlSum.Text)
            {
                Result.Text = "Целостность не нарушена";
            }
            else
            {
                Result.Text = "Целостность нарушена";
            }
        }
    }
}
