using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind_sweaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate Grid
            int[,] grid = new int[4, 6];
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    grid[x, y] = 0;
                }
                Console.WriteLine();
            }

            //Generate Bombs
            Random random = new Random();
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    if (random.Next(0, 7) == 5)
                    {
                        grid[x, y] = 8;
                    }
                    else
                    {
                        grid[x, y] = 0;
                    }
                }
            }

            //Increasing the values of the cells based on their neighbours
            for (int y = 0; y <= grid.GetLength(1); y++)
            {
                for (int x = 0; x <= grid.GetLength(0); x++)
                {
                    try
                    {
                        if (grid[x - 1, y] == 8 && grid[x,y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1; 
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x + 1, y] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x, y - 1] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x, y + 1] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x - 1, y + 1] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x - 1, y - 1] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x + 1, y + 1] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                    try
                    {
                        if (grid[x + 1, y - 1] == 8 && grid[x, y] != 8)
                        {
                            grid[x, y] = grid[x, y] + 1;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                }
            }

            int[,] printgrid = new int[4, 6];
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    printgrid[x, y] = 9;
                }
                Console.WriteLine();
            }
            Console.WriteLine("9 is an unguessed square.");
            drawGrid(printgrid);
            bool playing = true;
            while (playing == true)
            {
                Console.WriteLine("Please enter you X co-ordinate:");
                int xGuess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter you Y co-ordinate:");
                int yGuess = Convert.ToInt32(Console.ReadLine());
                printgrid[xGuess, yGuess] = grid[xGuess, yGuess];
                if (grid[xGuess, yGuess] == 8)
                {
                    Console.WriteLine("You set off a bomb!");
                    playing = false;
                    drawGrid(grid);
                    break;
                }

                drawGrid(printgrid);
            }
            


            //2D for loop to copy
            //            for (int y = 0; y < grid.GetLength(1); y++)
            //           {
            //                for (int x = 0; x < grid.GetLength(0); x++)
            //                {
            //                }
            //            }

            Console.ReadLine();
         }

        static void drawGrid(int[,] grid)
        {
            //Draw Grid
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    Console.Write("{0}", grid[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
