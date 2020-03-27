using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    public class Generator
    {
        public decimal seed { get; set; }
        public decimal a { get; set; }
        public decimal c { get; set; }
        public decimal M { get; set; }
        public int type { get; set; }

        /*
        public Generator Generator(float seed, float a, float c, float m, int type)
        {
            Generator rtn = new Generator();
            rtn.seed = seed;
            rtn.a = a;
            rtn.c = c;

        }

        public Generator Generator()
        {
            return new Generator(
                this.seed = 31767,
                this.a = 71561,
                this.c = 56822,
                this.M = 341157,
                this.type = 0
                );
        }
        */

        public List<decimal> Generate(int quantity)
        {
            List<decimal> result = new List<decimal>();

            for (int i=0; i<quantity; i++)
            {
                decimal rnd = ((this.a * this.seed) + this.c) % this.M;
                this.seed = rnd;
                rnd = rnd / (this.M -1 );
                rnd = Math.Truncate(rnd * 10000) / 10000;
                result.Add(rnd);
            }

            return result;
        }

        public decimal SingleGenerate()
        {
            decimal rnd = ((this.a * this.seed) + this.c) % this.M;
            this.seed = rnd;
            rnd = rnd / (this.M - 1);
            rnd = Math.Truncate(rnd * 10000) / 10000;
            return rnd;
        }
    }
}
