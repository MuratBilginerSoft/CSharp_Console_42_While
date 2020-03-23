using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_14_While_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // O ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yapalım

            int x = 0;
            int y = 100;
            int tç = 0, tt=0;


            while (x<y)
            {
                if (x%2!=0)
                {
                    //toplam = toplam + x;

                    tt += x;
                   
                }

                else
                {
                    tç += x;
                }


                x++;
            }

            Console.WriteLine("Çift Sayılar Toplamı={0} \nTek Sayılar Toplamı={1}",tç,tt);

            Console.ReadKey();
        }
    }
}
