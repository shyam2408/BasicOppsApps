


namespace BinarySearch
{
    class Program
    {
        public static void Main(string[]args)
        {
            int[] array={31,5,2,6,7,1,8};
           for(int i=0;i<array.Length;i++)
           {
            int min=i;
            for(int j=i;j<array.Length;j++)
            {
                if(array[min]>array[j])//(students[j].Age<students[min].Age)
                {
                    min=j;
                }    
            }
            int temp=array[i];
            array[i]=array[min];
            array[min]=temp;
           }

           foreach(int i in array)
           {
            Console.WriteLine(i);
           }
        }
    }
}

