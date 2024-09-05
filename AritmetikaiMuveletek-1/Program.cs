int sorokSzama = int.Parse(Console.ReadLine());
List<double> eredmenyek = new();
for (int i = 0; i < sorokSzama; i++)
{
    string sor = Console.ReadLine();
    var elemek = sor.Split(' ');
    if (elemek[1] == "+")
    {
        eredmenyek.Add(int.Parse(elemek[0]) + int.Parse(elemek[2]));
    }
    else if (elemek[1] == "-")
    {
        eredmenyek.Add(int.Parse(elemek[0]) - int.Parse(elemek[2]));
    }
    else if (elemek[1] == "*")
    {
        eredmenyek.Add(int.Parse(elemek[0]) * int.Parse(elemek[2]));
    }
    else if (elemek[1] == "/")
    {
        eredmenyek.Add(int.Parse(elemek[0]) / int.Parse(elemek[2]));
    }
    else if (elemek[1] == "%")
    {
        eredmenyek.Add(int.Parse(elemek[0]) % int.Parse(elemek[2]));
    }
}
foreach (var item in eredmenyek)
{
    Console.WriteLine(item);
}