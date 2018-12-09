using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class levelSettings
    {
        protected int numItems;//max5 per set
                               // protected int numItemSets;//max3
        public levelSettings()
        {
            numItems = 1;
            // numItemSets = 1;
        }
        public levelSettings(int numI)
        {
            numItems = numI;
        }
        /* public levelSettings(int numI, int numS)
         {
             numItems = numI;
             numItemSets = numS;
         }*/
    }
}
