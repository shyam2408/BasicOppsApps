
namespace BinarySearch
{
    class Program
    {
        public static void Main(string[]args)
        {
            int[] array={31,5,2,6,7,1,8};
            for(int i=1;i<array.Length;i++)
            {
                int j=i;//key=students[i];
                        //int j=i-1;
                while(j>0 && array[j]<array[j-1])//(j>=0 &&students[j].Age>key.Age)
                {
                    int temp=array[j];  //students[j+1]=students[j]
                    array[j]=array[j-1];//j--;
                    array[j-1]=temp;
                    j--;
                }
                //students[J+1]=key;
            }

           foreach(int j in array)
           {
            System.Console.Write(j);
           }
        }
    }
}