using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23_NewCD
{
    class Song
    {
        public string Name { get; set; }
        public int Length { get; set; } // Song in sec
        public string LengthMinSec
        {
            get
            {
                // 0 min 00 sec
                return string.Format("{0} min {1:00}", Length / 60, Length % 60);
            }
        }
    }
}
