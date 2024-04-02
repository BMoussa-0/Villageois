using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libvillageois
{
    public class Village
    {
        private List<Villageois> mesHabitants;
        private int superficie;
        private string name;
        private string description;
        public Village(int superficie, string name, string description) 
        {
            this.mesHabitants = new List<Villageois>();
            this.superficie = superficie;
            this.name = name;
            this.description = description;
        }
        
        public void AjouterVillageois(Villageois villageois)
        {
           mesHabitants.Add(villageois);
        }
        
        public void AjouterNewVillageois(string nom, int poids, bool malade, int potion)
        {
           Villageois villageois = new Villageois(nom, poids, malade, potion);
            mesHabitants.Add(villageois);
        }
        
        public Villageois GetVillageois(string name)
        {
            Villageois a=null;
            foreach (var habitant in mesHabitants) 
            {
                if (name == habitant.getNom()) { a = habitant; }
            }
            return a;   
        }
        
        public string GetNomVillage()
        {
            return this.name;
        }

        public List<Villageois> GetHabitants()
        {
            return this.mesHabitants;
        }
    }
}
