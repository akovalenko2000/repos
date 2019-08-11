using System;
class LECTURE2 {
  static void Main() {
    //create array with numbers of elements equals num_of_elem
    int num_of_elem =0;
    // fill the array
    num_of_elem = 4;
    int [] numbers=new int[num_of_elem]{1,2,3,5};
// change the order
    int value= 0;
double half = Floor(num_of_elem/2);
    for(int j = 0; j<half; ++j)
    {
        value = numbers[num_of_elem-1-j];
        numbers[num_of_elem-1-j]=numbers[j];
        numbers[j] = value;
    }
  }
}
