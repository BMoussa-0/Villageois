using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libvillageois
{
    public class Potions
    {
        private int doses;

        public Potions(int doses) 
        {
            this.doses = doses;
       
        }
        public int getDoses() {return this.doses;}

        public void ajouterDose(int doses)
        {
            this.doses += doses;
        }
        public double ConsequencesDoses() 
        { 
            double res = 0;
            if (this.doses < 5 && this.doses != 0) 
            {
                res = 0.5;
            }
            return res;
        }
    
    
            }
}
