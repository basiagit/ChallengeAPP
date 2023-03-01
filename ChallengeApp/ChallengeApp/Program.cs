string name = "Ewa";
string gender = "female";
var age = 33;
if (gender == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age ==33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}   
else if (gender != "female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("osoba nie spełniająca warunków");
}

