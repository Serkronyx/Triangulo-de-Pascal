using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriPascalBueno
{
    class Utility
    {
        /*
        static void Copy(int[] src, int[] dst)
        {
            for (int copi = 0; copi < src.Length; copi++)
            {
                dst[copi] =src[copi];
            }
        }

        */
        public static void Copy(int[] dst, int[] src)
        {
            //throw new NotImplementedException();
            for (int copi = 0; copi < src.Length; copi++)
            {
               dst[copi] = src[copi];
            }
        }
    }
    
        
        
}
