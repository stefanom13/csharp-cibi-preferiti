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

//stampata cibi  migliori peggiori e al centro //

if (cibiPref != null && cibiPref.Length > 0)
{
    //stampo cibo preferito //
    Console.WriteLine("\nCibo preferito: " + cibiPref[0]);

    //stampo cibo meno preferito //
    Console.WriteLine("\nCibo meno preferito: " + cibiPref[cibiPref.Length - 1]);

    //stampo cibo nel mezzo //
    if (cibiPref.Length % 2 == 0)
    {
        Console.WriteLine("\nCibo mediani: " + cibiPref[cibiPref.Length / 2 - 1] + " e " + cibiPref[cibiPref.Length / 2]);
    }
    else
    //stampo cibo nel mezzo  else//
    {
        Console.WriteLine("\nCibo mediano: " + cibiPref[cibiPref.Length / 2]);
    }
}
