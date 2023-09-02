using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    public class rectangle
    {
        // 1. Ein Feld mit einem typischen Zugriffsmodifizierer
        public int lenght;
        // 2. Ein read-only Feld
        public readonly int width = 10; // man kann das nicht wechseln
        // 3. standardWert zugewiesen
        private int height = 5;

        private int area;

        public int Area
        {
            get { return area;  }
        }
    }
}
