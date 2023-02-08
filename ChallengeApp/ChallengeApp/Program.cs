var name = "Ewa";
var sex = "kobieta";
var age = 33;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}