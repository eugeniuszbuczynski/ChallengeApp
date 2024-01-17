// ZADANIE DOMOWE DZIEŃ 4

// Kobieta poniżej 30 lat
// Ewa lat 30
// niepełnoletni mężczyzna

string name = "Ewa";
var sex = "mężczyzna";
int age = 60;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("nie jestem w stanie sklasyfikować");
}
