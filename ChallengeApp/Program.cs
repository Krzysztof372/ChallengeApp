var name = "Ewa";
var sex = "female";
var age = 33;

if (age < 30 && sex == "female")
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (age < 18 && sex != "female")
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
