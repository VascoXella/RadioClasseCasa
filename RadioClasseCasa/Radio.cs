using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioClasseCasa
{
    internal class Radio
    {
        public float Volume { get; set; }

        public Radio()
        {
        }
        
        public float Aumentav()
        {
            return (float)(Volume + 0.1 * Volume);
        }

        public float Diminuisciv()
        {
            return (float)(Volume - 0.1 * Volume);
        }

    }
}
