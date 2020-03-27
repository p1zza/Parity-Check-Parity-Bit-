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
        public List<int> even = new List<int>();
        public List<int> odd = new List<int>();



        public Form1()
        {
            InitializeComponent();
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            var s = StrToAsciiArray(name);
            List<string> vs = new List<string>();
            var d = ToBinary(vs, s);

            d = GetParitetBytes(d);

            Result.Text = name + even.ToString() + "\n"+ odd.ToString();


            var mas_even = even.ToArray();
            var mas_odd = odd.ToArray();
            var mas_d = d.ToArray();

            string res = "";
            res += "| " + "Входная строка"+ " | " + "even" + " | " + "odd" + " |\n";

            for (int i = 0; i < name.Length;i++)
            {
                res += "|      " + mas_d[i] + "       |    " +mas_even[i]+ "    |   " + mas_odd[i] + "   |\n";
            }

            Result.Text = res;
        }

        
        

        private List<string> GetParitetBytes(List<string> input)
        {
            int sum = 0;
            foreach(var s in input)
            {
                s.ToCharArray();
                for(int i=0;i<s.Length;i++)
                {
                    sum += Convert.ToInt32(s[i].ToString());
                }
                even.Add(sum % 2);
                if (sum%2 == 1)
                {
                    odd.Add(0);
                }
                else
                {
                    odd.Add(1);
                }
            }

            return input;
        }

        private byte[] StrToAsciiArray(string s)
        {
            return Encoding.UTF8.GetBytes(s.ToCharArray());
        }

        private List<string> ToBinary(List<string> input, byte[] bin_input)
        {
            foreach (var s in bin_input)
            {
                input.Add((Convert.ToString(s, 2).PadLeft(8, '0')));
            }
            return input;
        }
    }


}
