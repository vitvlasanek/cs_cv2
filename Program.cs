using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cviceni2_tetris
{
    class MultidimensionalArray
    {
        int x = 0;
        int y = 0;

        public void ShapeOfL(ref int x, ref int y, bool[,] playingField)
        {
            playingField[x, y] = true;
            playingField[x, y + 1] = true;
            playingField[x, y + 3] = true;
            playingField[x + 1, y] = true;
            if(x+3 > playingField.GetLength(0))
            {
                x = 0;
            }

        }

        public void ShapeOfT(ref int x, ref int y, bool[,] playingField)
        {
            playingField[x, y] = true;
            playingField[x, y + 1] = true;
            playingField[x, y + 2] = true;
            playingField[x + 1, y] = true;
        }

        public void Run()
        {
            bool[,] playingField = new bool[20, 20];

            //ShapeOfT(ref x, ref y, playingField);

            while (true)
            {
                x++;

                Thread.Sleep(100);
                for (int i = 0; i < playingField.GetLength(0); i++)
                {
                    for (int j = 0; j < playingField.GetLength(1); j++)
                    {
                        playingField[i, j] = false;
                    }
                }
                ShapeOfL(ref x, ref y, playingField);
                Console.Clear();
                Console.SetCursorPosition(5, 5);
                MainLoop(playingField);
                Console.CursorVisible = false;
            }

        }

        public void MainLoop(bool[,] playingField)
        {
            for (int i = 0; i < playingField.GetLength(0); i++)
            {
                for (int j = 0; j < playingField.GetLength(1); j++)
                {
                    if (playingField[i, j])
                        Console.Write("██");
                }
                Console.WriteLine();
            }
            Console.WriteLine("x={0}, y={1}", x, y);
        }

        static void Main(string[] args)
        {
            MultidimensionalArray obj = new MultidimensionalArray();

            obj.Run();

            Console.ReadLine();
        }
    }
}

/*for (int i = 0; i < 10; i++)
            {
                if (playingField[5, 5])
                {
                    Console.WriteLine("█");
                }
            }*/

/*bool keepgoing = true;
           while (keepgoing)
           { 
               Console.WriteLine("█");
           }*/


/*public class Coordinates
        {
             public int x; 
             public int y;

            public Coordinates(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }*/

/*bool keepgoing = true;

           while (keepgoing)
           {
           Console.SetCursorPosition(0, 0);
           if (somecondition)
           {
               Console.WriteLine("█");
           }
           Console.Clear();

           }
           //Thread.Sleep(1000);*/