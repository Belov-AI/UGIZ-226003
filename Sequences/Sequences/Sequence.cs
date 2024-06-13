using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences
{
    public class Sequence
    {
        public IEnumerable Fibonacci()
        {
            long a = 0;
            long b = 1;

            yield return a;
            yield return b;

            long c;

            while (true)
            {
                c = a + b;
                yield return c;

                a = b;
                b = c;
            }
        }

        public IEnumerable Factorial()
        {
            long f = 1;
            long n = 1;

            while (true)
            {
                f = f * n;
                yield return f;
                n++;
            }
        }
    }
}
