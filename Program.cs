using CodeProjects;
using CodeProjects.TreeOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //int rowsAndColumns = 4;
            //var matrix = new MatrixProblems(rowsAndColumns, rowsAndColumns);
            //matrix.Print();
            //// matrix.RotateClockwise();
            //// Console.WriteLine("After rotation");
            //Console.WriteLine("Spiral printing...");
            //matrix.PrintSpiralOfMatrix();

            //var knightTour = new KinghtsTour(64);
            //knightTour.PerformKnightTour(0, 0, 1);
            //knightTour.Print();
            // matrix.Print();


            //var maximumPathSumtree = new MaximumPathSum();
            //maximumPathSumtree.CreateTree(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            //Console.WriteLine("Print tree...");
            //maximumPathSumtree.PrintTreeInorder();
            //var maxPathSum = maximumPathSumtree.GetMaximumPathSum();
            //Console.WriteLine("Maximum path sum value: " + maxPathSum);

            var reverseArray = new ReverseArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

            Console.WriteLine("Print before reverse...");
            reverseArray.Print();
            reverseArray.Reverse();

            Console.WriteLine("Print after reverse...");
            reverseArray.Print();
            Console.ReadKey();
        }
    }
}
