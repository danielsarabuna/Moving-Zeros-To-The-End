using System;

public class Program
{  
  public static int[] MoveZeroes(int[] arr)
  {
    int[] result = new int[arr.Length];
    int targetResult = 0;
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] != 0)
        result[targetResult++] = arr[i];
    return result;
  }
}