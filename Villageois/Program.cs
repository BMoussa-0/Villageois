using libvillageois;

Villageois a, b;
string rep;
a = new Villageois("Panoramix", 16, true);
b = new Villageois("Abraracourcix");
Console.WriteLine(b.getPoids());
b.setPoids(26);
Console.WriteLine(a.ToString());
Console.WriteLine(a.getNom()); //le nom de a 
Console.WriteLine(a.getPoids());//le poids de a
Console.WriteLine(a.poidsSouleve()+"Kg");//le poids souleve de a et b
Console.WriteLine(a.soulevememepoids(b));//compare a et b
string res = "";
if (a.soulevememepoids(b)) { res = "Les villageois ont la même force"; }
else { if (a.getPoids() > b.getPoids()) { res = "Le villageois a est plus fort que le villageois b"; }
else { res = "Le villageois b est plus fort que le villageois a"; }
}

Console.WriteLine(res);

a.setDose(3);

Console.WriteLine ($"{a.getNom()} prend {a.getPotion().getDoses()} doses") ;

Console.WriteLine ("Apres les doses " + a.plusFort(b));

Console.WriteLine( $"{a.getNom()} soulève {a.poidsSouleve()} poids");

Console. WriteLine($"{b.getNom()} soulève {b.poidsSouleve()} poids");