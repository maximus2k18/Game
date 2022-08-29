namespace Z_C.ClassLibrary1
{
    public class Class1
    {
        public static string Checkwin(int[,] matrix)
        {
            if (matrix[0, 0] + matrix[0, 1] + matrix[0, 2] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[1, 0] + matrix[1, 1] + matrix[1, 2] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[2, 0] + matrix[2, 1] + matrix[2, 2] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[0, 0] + matrix[1, 1] + matrix[2, 2] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[0, 2] + matrix[1, 1] + matrix[2, 0] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[0, 0] + matrix[1, 0] + matrix[2, 0] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[0, 1] + matrix[1, 1] + matrix[2, 1] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[0, 2] + matrix[1, 2] + matrix[2, 2] == 3)
            {
                return "Zeros win!";
            }
            if (matrix[0, 0] + matrix[0, 1] + matrix[0, 2] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[1, 0] + matrix[1, 1] + matrix[1, 2] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[2, 0] + matrix[2, 1] + matrix[2, 2] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[0, 0] + matrix[1, 1] + matrix[2, 2] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[0, 2] + matrix[1, 1] + matrix[2, 0] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[0, 0] + matrix[1, 0] + matrix[2, 0] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[0, 1] + matrix[1, 1] + matrix[2, 1] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[0, 2] + matrix[1, 2] + matrix[2, 2] == 12)
            {
                return "Сrosses win!";
            }
            if (matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[2, 0] + matrix[2, 1] + matrix[2, 2] == 24)
            {
                return "Draw!";
            }
            return "";
        }
    }
}