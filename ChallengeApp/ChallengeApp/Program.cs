// zadanie domowe dzień 4

string name = "Ewa";
var sex = "kobieta";
int age = 30;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if ((!(sex == "kobieta")) && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("nie jestem w stanie sklasyfikować");
}
