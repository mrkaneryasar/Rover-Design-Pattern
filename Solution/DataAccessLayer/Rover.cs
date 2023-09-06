using System;
using rover_design_pattern;


    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Direction { get; private set; }

        public Rover(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void Move(string commands, Plato plato)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward(plato);
                        break;
                    default:
                        Console.WriteLine($"Geçersiz komut: {command}");
                        break;
                }
            }
        }

        private void TurnLeft()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'W';
                    break;
                case 'W':
                    Direction = 'S';
                    break;
                case 'S':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'N';
                    break;
                default:
                // burada hata döndürebiliriz
                break;
            }
        }

        private void TurnRight()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'S';
                    break;
                case 'S':
                    Direction = 'W';
                    break;
                case 'W':
                    Direction = 'N';
                    break;
                default:
                    // burada hata döndürebiliriz
                    break;
            }
        }

        private void MoveForward(Plato plato)
        {
            switch (Direction)
            {
                case 'N':
                    if (Y < plato.Y)
                        Y++;
                    break;
                case 'E':
                    if (X < plato.X)
                        X++;
                    break;
                case 'S':
                    if (Y > 0)
                        Y--;
                    break;
                case 'W':
                    if (X > 0)
                        X--;
                    break;
                default:
                // burada hata döndürebiliriz
                break;
            }
        }
    }

