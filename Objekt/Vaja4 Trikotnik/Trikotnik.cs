using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vaja4_Trikotnik
{
    public class Trikotnik
    {
        public int a,b,c;

        public Trikotnik()
        {
            Random rnd = new Random();
            this.a = rnd.Next(1, 10);
            this.b = rnd.Next(1, 10);
            while (true){
                this.c = rnd.Next(1, 10);
                if (this.a + this.b > this.c && this.a + this.c > this.b && this.b + this.c > this.a){
                    break;
                }
            }
        }
        public Trikotnik(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        


    }
}