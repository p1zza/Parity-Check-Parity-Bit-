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

        public string alphabet = "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" ;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            string input = SendlerText.Text;
            //input = input.Replace(" ", "");
            string AlphabetNumbers = StrToNumArray(input);
            //string Numbers = GetNumbers(AsciiInput);

            string ControlSum = GetControlSum(AlphabetNumbers);


            ControlSumSendlerText.Text = "" +  ControlSum.GetHashCode();

            ReceiverText.Text = SendlerText.Text;
        }

        
        
        private string GetControlSum(string s)
        {
            //считаем сумму нечетных битов
            int Sn = 0;
            s += " "; // чтобы добавить в конце новый символ проверки, добавляем в конце пробел
            char[] input = s.ToCharArray();
            //так как программируем с нуля, работаем с ними как с четными
            for (int i = 0; i < input.Length; i++)
            {
                if(i%2 == 0) //если символ четный, складываем с суммой нечетных
                {
                    if((input[input.Length-1]==' ')&& (input[i] == ' '))
                    {
                        //условие, которое не считает последний пробел в общую сумму
                        break;
                    }
                    Sn += input[i] - '0'; //прибавляем к сумме char с приведением его к типу int
                }
            }
            //считаем сумму нечетных битов
            int Sch = 0;
            //так как программируем с нуля, работаем с ними как с нечетными
            for (int i = 0; i < input.Length - 1; i++)
            {
                if ((i % 2 == 1))//если символ нечетный, складываем с суммой четных
                {
                    Sch += input[i] - '0';//прибавляем к сумме char с приведением его к типу int
                }
            }

            for (int i = 1; i < 10000; i++)
            {
                char Cd;
                try
                {
                    if ((Sn + Sch + i) % 10 == 0)
                    {
                        Cd = Char.Parse(i.ToString());
                        input[input.Length - 1] = Cd;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    //Исключение, которое отрабатывает, когда i в условии равно 10.
                    //а двузначный символ в char перевести нельзя
                    if (i == 10)
                    {
                        Cd = Char.Parse("1");
                        input[input.Length - 1] = Cd;
                        break;
                    }

                }

            }
            s = new String(input);

            return s;
        }
        
        //private string GetNumbers(byte[] byteinput)
        //{
        //    string NumbersOutput = "";
            
        //    for(int i = 0; i< byteinput.Length;i++)
        //    {
        //        NumbersOutput += byteinput.GetValue(i);
        //    }
        //    return NumbersOutput;
        //}

        private string StrToNumArray(string s)
        {
            s= s.ToUpper();
            string output = "";
            for(int i =0; i< s.Length; i++)
            {
                var array = s.ToArray();
                output += alphabet.IndexOf(array[i]);
            }
            return output;
        }

        private void CheckMessage_Click(object sender, EventArgs e)
        {
            string input = ReceiverText.Text;
            //input = input.Replace(" ", "");
            //byte[] AsciiInput = StrToNumArray(input);
            string Numbers = StrToNumArray(input);
            //string Numbers = GetNumbers(AsciiInput);

            string ControlSum = GetControlSum(Numbers);
            ControlSum = "" + ControlSum.GetHashCode();
            if(ControlSum == ControlSumSendlerText.Text)
            {
                IsOK.Text = "Целостность не нарушена";
            }
            else
            {
                IsOK.Text = "Целостность нарушена";
            }
        }
    }


}
