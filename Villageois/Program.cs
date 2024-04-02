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
Console.WriteLine(a.plusFort(b));

a.setDose(3);

Console.WriteLine ($"{a.getNom()} prend {a.getPotion().getDoses()} doses") ;

Console.WriteLine ("Apres les doses " + a.plusFort(b));

Console.WriteLine( $"{a.getNom()} soulève {a.poidsSouleve()} poids");

Console. WriteLine($"{b.getNom()} soulève {b.poidsSouleve()} poids");

Village villageGaulois = new Village(5000, "glenBret", "petit village");

villageGaulois.AjouterVillageois(a);

villageGaulois.AjouterVillageois(b);

villageGaulois.AjouterNewVillageois("Homéopatix", 20, true, 3);

Console.WriteLine(villageGaulois.GetVillageois("Abraracourcix").ToString());

Console.WriteLine($"Il y a {villageGaulois.GetHabitants().Count} habitants dans le village {villageGaulois.GetNomVillage()}");
