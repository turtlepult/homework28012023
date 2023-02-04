// Написать программу масштабирования фигуры
Console.WriteLine("введите количество вершин: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("введите коофициент маштабирования: ");
int k = int.Parse(Console.ReadLine()??"0");
int[] coor = new int[n*2];
int count = 1; //счетчик для подсчета текущего х, у
for (int i = 0; i < n*2; i++)
    { 
        if (i%2==0) // для разбивки на х, у 
        {
        Console.WriteLine("введите координату х"+count+": ");
        int temp = int.Parse(Console.ReadLine()??"0");
        coor[i] = temp;
        }
        else
        {
        Console.WriteLine("введите координату y"+count+": ");
        int temp = int.Parse(Console.ReadLine()??"0");
        coor[i] = temp; 
        count++;
        }
    }
for (int i = 0; i < coor.Length; i++)
{
    coor[i]=coor[i]*k;
}
Console.WriteLine();
count = 1;//сбрасываем счетчик
for (int i = 0; i < n*2; i++)
    { 
        if (i%2==0) // для разбивки на х, у 
        {
        Console.WriteLine("координа х"+count+": "+coor[i]);
        }
        else
        {
        Console.WriteLine("координа y"+count+": "+coor[i]);
        count++;
        }
    }