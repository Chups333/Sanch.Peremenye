using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Peremenye
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            i = 6;
            //i = "asa" - нельзя
            i = -31;

            double j = 5;
            j = 5.0;
            j = 4.3;

            char c = 'a';
            c = '1';

            bool d = true;
            d = false;

            string s = "hello";
            var ss = "world dasdasd asdsd asd ";

            decimal e = 0.1M;

            float t = 0.1F;

            int y = 5;
            dynamic o = 5;

           // y.sadasdsd(); - ошибка
           // o.asdasdasd(); - нет ошибки (тип позволяет)
        }
    }
}
