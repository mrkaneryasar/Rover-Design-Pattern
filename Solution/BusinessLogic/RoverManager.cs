using System;
namespace rover_design_pattern
{
	
        public class RoverManager
        {
            public static void Start()
            {
                Console.Write("Platonun koordinatlarını giriniz : ");
                string[] boundaries = Console.ReadLine().Split(' ');
                int platoX = int.Parse(boundaries[0]);
                int platoY = int.Parse(boundaries[1]);

                Plato plato = new Plato(platoX, platoY);

                int remainingAttempts = 5;

                while (remainingAttempts > 0)
                {
                    Console.WriteLine("Şimdi Rover bilgilerini girin, Çıkmak için 'E' tuşuna basınız.");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "e")
                        break;

                    string[] roverInfo = input.Split(' ');
                    if (roverInfo.Length != 3)
                    {
                        Console.WriteLine("Geçersiz rover bilgisi, Tekrar deneyiniz.");
                        continue;
                    }

                    int roverX = int.Parse(roverInfo[0]);
                    int roverY = int.Parse(roverInfo[1]);
                    char roverMoveInfo = char.Parse(roverInfo[2].ToUpper());

                    Console.Write("Rover komutlarını (örn:LMLMLMLMM) giriniz : ");
                    string commands = Console.ReadLine();

                    Rover rover = new Rover(roverX, roverY, roverMoveInfo);
                    rover.Move(commands, plato);

                    // Son konum bilgisi
                    Console.WriteLine($"Son pozisyon: {rover.X} {rover.Y} {rover.Direction}");

                    remainingAttempts--;

                    Console.WriteLine($"Kalan Hareket Hakkınız: {remainingAttempts} ");
                }

                if (remainingAttempts == 0)
                {
                    Console.WriteLine("Hakkınız bitti!");
                }
            }
        }

    
}

