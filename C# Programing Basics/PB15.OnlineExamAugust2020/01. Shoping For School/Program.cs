using System;

namespace _01._Shoping_For_School
{
    class Program
    {
        // static data
        static double packPencil = 4.75;
        static double packPen = 1.80;
        static double drawingBoard = 6.50;
        static double notebook = 2.50;

        static void Main(string[] args)
        {
            // input
            double pencilNeeded = double.Parse(Console.ReadLine());
            double penNeeded = double.Parse(Console.ReadLine());
            double drawingBoardNeeded = double.Parse(Console.ReadLine());
            double notebookNeeded = double.Parse(Console.ReadLine());

            // calculation
            double sumPencil = pencilNeeded * packPencil;
            double sumPen = penNeeded * packPen;
            double sumDrawingBoard = drawingBoardNeeded * drawingBoard;
            double sumNotebook = notebookNeeded * notebook;
            double sumBeforeDiscount = sumPencil + sumPen + sumDrawingBoard + sumNotebook;
            double finalTotal = sumBeforeDiscount - (sumBeforeDiscount * 0.05);


            // output
            Console.WriteLine($"Your total is {finalTotal:f2}lv");
        }
    }
}
