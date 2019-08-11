using System;

class LECTURE2
{
    public enum Sorting_type { Decrease, Increase};
    
    static public int [] sorting_by_increase(int [] array) 
    {
        int num_of_arr_elem = array.Length;
        int [] sorted_array = new int [num_of_arr_elem];
        int swap = 0;
        for(int i = 0; i< num_of_arr_elem; i++)
        {
            sorted_array[i]=array[i];
        }
        for (int i = 0; i < num_of_arr_elem; i++)
        {
            for (int j = 0; j < num_of_arr_elem - i - 1; j++)
            {
                if (sorted_array[j] > sorted_array[j + 1])
                {
                    swap = sorted_array[j];
                    sorted_array[j] = sorted_array[j + 1];
                    sorted_array[j + 1] = swap;
                }
            }
        }
        return sorted_array;
    }
    static public int [] sorting_by_decrease(int [] array)
    {
        int num_of_arr_elem = array.Length;
        int [] sorted_array = new int [num_of_arr_elem];
        int swap = 0;
        for(int i = 0; i< num_of_arr_elem; i++)
        {
            sorted_array[i]=array[i];
        }
        for (int i = 0; i < num_of_arr_elem; i++)
        {
            for (int j = 0; j < num_of_arr_elem - i - 1; j++)
            {
                if (sorted_array[j] < sorted_array[j + 1])
                {
                    swap = sorted_array[j+1];
                    sorted_array[j+1] = sorted_array[j ];
                    sorted_array[j] = swap;
                }
            }
        }
        return sorted_array;
    }
   /* public static int [] Sorting (int [] array, Enum Sorting_type)
    {
        if(Sorting_type==Decrease)
        {
            return sorting_by_decrease(array);
        }
        else if(Sorting_type==Increase)
        {
            return sorting_by_increase(array);
        }
    }*/
  static void Main ()
  {
      int [] Myarray = new int []{1,4,2,7,3};
      int [] Newarr1 = sorting_by_decrease(Myarray);
      int [] Newarr2 = sorting_by_increase(Myarray);
  }
}

