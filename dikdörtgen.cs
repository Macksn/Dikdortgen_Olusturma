using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASS_DİKDÖRTGEN_
{
    class dikdörtgen
    {
        public int uzun, kisa;
        public int alan()
        {
            return (uzun * kisa);
        }

        public int cevre()
        {
            return (2 * (uzun + kisa));
        }
       
    }
}
