class MyMatrix
{
    int row, columns;
    int[,] matr;

    public int min { get; set; } = 0;
    public int max { get; set; } = 9;

    public MyMatrix(int a, int b)
    {
        row = a;
        columns = b;
        Random rand = new Random();
        matr = new int[a, b];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = rand.Next(min, max);
            }
        }
    }

    public int this[int row, int columns]
    {
        get => matr[row, columns];
        set => matr[row, columns] = value;
    }

    public void Fill()
    {
        Random rand = new Random();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matr[i, j] = rand.Next(min, max);
            }
        }
    }

    public MyMatrix ChangeSize(int a, int b)
    {
        MyMatrix temp = new MyMatrix(a, b);
        if (temp.row > row || temp.columns > columns)
        {
            Random rand = new Random();
            if (temp.row > this.row && temp.columns > this.columns)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        matr[i, j] = rand.Next(min, max);
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        temp[i, j] = this[i, j];
                    }
                }
            }
            else if (temp.row > this.row)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matr[i, j] = rand.Next(min, max);
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        temp[i, j] = this[i, j];
                    }
                }
            }
            else if (temp.columns > this.columns)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        matr[i, j] = rand.Next(min, max);
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        temp[i, j] = this[i, j];
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    temp[i, j] = this[i, j];
                }
            }
        }
        row = temp.row;
        columns = temp.columns;
        matr = temp.matr;
        return this;
    }

    public void ShowPartialy(int start_row, int start_column, int end_row, int end_column)
    {
        Console.WriteLine();
        for (int i = start_row; i < end_row; i++)
        {
            for (int j = start_column; j < end_column; j++)
            {
                string temp = this[i, j].ToString();
                Console.Write(temp.PadRight(max.ToString().Length + 3));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void ShowPartialy()
    {
        Console.WriteLine();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                string temp = this[i, j].ToString();
                Console.Write(temp.PadRight(max.ToString().Length + 3));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}