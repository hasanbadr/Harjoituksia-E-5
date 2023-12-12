using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä lause: ");
        string lause = Console.ReadLine();

        // Erotellaan lause sanaparsiksi
        string[] sanat = lause.Split(' ');

        string pisinSana = "";

        foreach (string sana in sanat)
        {
            // Poistetaan mahdolliset erikoismerkit sanoista (esim. pilkut, pisteet)
            string puhdistettuSana = new string(sana.Where(char.IsLetter).ToArray());

            if (puhdistettuSana.Length > pisinSana.Length)
            {
                pisinSana = puhdistettuSana;
            }
        }

        Console.WriteLine($"Pisimmän sanan pituus on {pisinSana.Length} merkkiä:");
        Console.WriteLine(pisinSana);
    }
}