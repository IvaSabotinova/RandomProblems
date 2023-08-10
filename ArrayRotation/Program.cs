
Console.WriteLine(string.Join(", ", ArrayRotation(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3)));
static int[] ArrayRotation(int[] array, int step)
{
    int[] resultArray = new int[array.Length];
 
    //for (int i = 0; i < array.Length; i++)

    //{
    //    if (i + step < array.Length)
    //    {
    //       resultArray[i + step] = array[i];          
           
    //    }
    //    else
    //    {
    //        Array.Copy(array, i, resultArray, 0, step);
    //        break;
    //    }

    //}
    Array.Copy(array, 0, resultArray, step, array.Length-step);
    Array.Copy(array, step + 1, resultArray, 0, step);  
    return resultArray;
}
