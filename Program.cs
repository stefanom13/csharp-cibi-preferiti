// See https://aka.ms/new-console-template for more information

// listaCibi e stampata lunghezza //

string[] cibiPref = { "Hamburger", "Pizza", "Pasta", "Insalata di Mare", "Parmigiana", "Riso con Tonno" };

Console.WriteLine("\nLunghezza della classifica: " + cibiPref.Length);

//stampata classifica //

Console.WriteLine("\nCLASSIFICA: ");
for (int i = 0; i < cibiPref.Length; i++)
{
    Console.WriteLine(i + 1 + " - " + cibiPref[i]);
}


