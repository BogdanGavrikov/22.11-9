using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1;
            num1 = Interaction.InputBox("Введите первое число",
                "Ввод первого числа");
            string num2;
            num2 = Interaction.InputBox("Введите второе число",
                "Ввод второго числа");
            int x = Convert.ToInt32(num1);
            int y = Convert.ToInt32(num2);
            int answer = x + y;
            string res = answer.ToString();

            MessageBox.Show(res, "Сумма");
        }
    }
}
