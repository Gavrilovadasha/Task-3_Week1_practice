using System;

namespace ChessQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат ферзя и фигуры.
            Console.WriteLine("Введите координаты ферзя и фигуры в формате 'a1 b2':");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');

            // Проверка корректности введенных данных.
            if (coordinates.Length != 2 || !IsValidCoordinate(coordinates[0]) || !IsValidCoordinate(coordinates[1]))
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            // Получение координат ферзя и фигуры.
            char queenColumns = coordinates[0][0];
            int queenRows = int.Parse(coordinates[0][1].ToString());
            char figureColumns = coordinates[1][0];
            int figureRows = int.Parse(coordinates[1][1].ToString());

            // Проверка бьёт ли ферзь фигуру.
            if (queenColumns == figureColumns || queenRows == figureRows || Math.Abs(queenColumns - figureColumns) == Math.Abs(queenRows - figureRows))
            {
                Console.WriteLine("Ферзь сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Ферзь не сможет побить фигуру");
            }
        }

        // Проверка корректности координат.
        static bool IsValidCoordinate(string coordinate)
        {
            if (coordinate.Length != 2)
            {
                return false;
            }

            char colomns = coordinate[0];
            int rows = int.Parse(coordinate[1].ToString());

            return (colomns >= 'a' && colomns <= 'h') && (rows >= 1 && rows <= 8);
        }

    }
}