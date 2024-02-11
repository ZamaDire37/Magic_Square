using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Square
{
    internal class ProblemALG004r
    {
        private int n;
        private int[,] magicSquare;
        public  ProblemALG004r(int n)
        {
            if (n%2 == 0)
            {
                Console.WriteLine("Magic square shape must be odd");
                return;
            }
            this.n = n;
            this.magicSquare = new int[n, n];
            CreateMagicSquare();
        }
        private void CreateMagicSquare()
        {
            int x = 1;
            int row = 0;
            int col = n / 2;
            while (x <= n * n)
            {
                magicSquare[row, col] = x;
                x++;
                int newRow = (row - 1 + n) % n;
                int newCol = (col +1 + n) % n;
                if (magicSquare[newRow, newCol] != 0)
                {
                    row=(row + 1) % n;
                }
                else
                {
                    row = newRow;
                    col=newCol;
                }
            }
        }
        private int[,] Rotate()
        {
            int[,] rotatedSquare = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedSquare[j,n-1-i]= magicSquare[i,j];
                }
            }
            this.magicSquare= rotatedSquare;
           return rotatedSquare;
            
        }

        public void PrintMGS()
        {
            int[,] rotatedSquare = (int[,])magicSquare.Clone();
            for (int i = 0; i < 3; i++)
            {
                rotatedSquare= Rotate();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(rotatedSquare[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
  
}
