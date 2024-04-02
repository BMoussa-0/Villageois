using System;
using System.Reflection.Metadata.Ecma335;

namespace libvillageois
{
    public class Villageois
    {
        private string nom;
        private int poids;
        private bool malade;
        private Potions maPotion;

        public Villageois(string nom)
        {
            this.nom = nom;
            this.malade = false;
            this.maPotion = new Potions(0);

        }

        public Villageois(string nom, int poids, bool malade)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potions(0);

        }

        public Villageois(string nom, int poids, bool malade, int potion)
        {
            this.nom = nom;
            this.poids = poids;
            this.malade = malade;
            this.maPotion = new Potions(potion);
        }
        
        public Potions getPotion() { return  maPotion; }
        
        public string getNom() { return this.nom; }

        public bool getMalade() { return this.malade; }

        public int getPoids() { return this.poids; }

        public override string ToString()
        {
            return "Le villageois se nomme" + nom + "il peut soulever" + poids + "et est" + malade;
        }

        public int poidsSouleve()
        {
            double dopage = maPotion.ConsequencesDoses();
            double souleve = poids * (1 + dopage);
            int x = Convert.ToInt32(souleve);
            return x / 5;

        }

        public void setPoids(int a)
        {
            this.poids = a;
        }

        public void setDose(int b)
        {
            maPotion.ajouterDose(b);
        }
        public bool soulevememepoids(Villageois c)
        {
            bool flag = false;
            if (this.poids == c.getPoids()) flag = true;
            return flag;
        }

        public string plusFort( Villageois b)
        {
            string res = "";
            if (this.soulevememepoids(b)) { res = "Les villageois ont la même force"; }
            else
            {
                if (poids > b.getPoids()) { res = "Le villageois a est plus fort que le villageois b"; }
                else { res = $"Le villageois {b.getNom()} est plus fort que le villageois {this.getNom()}"; }
            }
            return res;
        }

        
    }

}