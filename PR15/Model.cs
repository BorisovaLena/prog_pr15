using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PR15
{
    public static class Model
    {
        // блок с данными
        public static List<char> signsList = new List<char> {'+','-','*','/'};
        static int rez = 0;

        // блок для обращения к текстовым полям
        public static TextBlock tb;
        public static TextBox result;

        // блок с бизнес-логикой
        public static int Position
        {
            set
            {
                tb.Text = signsList[value].ToString();
            }
        }
        public static int Calculation
        {
            set
            {
                rez = value;
                result.Text = rez.ToString();
            }
        }
    }
}
