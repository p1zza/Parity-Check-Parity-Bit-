using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypt_8
{
    static class Alghorytm
    {
        public static string alphabet = "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string StrToNumArray(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += alphabet.IndexOf(input.ToUpper().ToArray().GetValue(i).ToString().ToCharArray().FirstOrDefault());
            }
            return output;
        }
        public static string GetControlSum(string s)
        {
            int Sn = 0;
            s += " ";
            char[] input = s.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if ((input.GetValue(input.Length - 1).ToString().ToCharArray().FirstOrDefault() == ' ') 
                        && (input.ToArray().GetValue(i).ToString().ToCharArray().FirstOrDefault() == ' '))
                    {
                        break;
                    }
                    Sn += input[i] - '0';
                }
            }
            int Sch = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if ((i % 2 == 1))
                {
                    Sch += input[i] - '0';
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
                    if (i == 10)
                    {
                        Cd = Char.Parse("1");
                        input[input.Length - 1] = Cd;
                        break;
                    }
                }
            }
            return new String(input);
        }

    }
}
