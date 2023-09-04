using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wutmeter
{
    internal class person
    {
        private string name;
        private int wutMeter;

        public void Provizieren() { wutMeter++; }

        public void herunterFahren() { wutMeter--; }
        public void KopfAnschlagen() { wutMeter++; }
        public void jogginggehen() { wutMeter--; }

    }
}
