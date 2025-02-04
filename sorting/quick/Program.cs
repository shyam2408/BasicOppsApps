using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace BinarySearch
{
    class Program
    {
        public static void Main(string[]args)
        {
            int[] arr={31,5,2,6,7,1,8};
            QuickSort( arr,0,arr.Length-1);
            foreach(int i in arr)
            System.Console.WriteLine(i);
        }
        static void QuickSort(int[]arr,int low,int high)
        {
            if(low<high)
            {
                int pivotIndex=Partitioner( arr,low,high);


                QuickSort(arr,low,pivotIndex-1);
                QuickSort(arr,pivotIndex+1,high);

            }

        }


        static int Partitioner(int[]arr,int low,int high)
        {
            int pivot=arr[high];
            int i=low-1;

            for(int j=low;j<high;j++)
            {
                if(arr[j]<pivot)//students[j].age<pivot.Age
                {
                    i++;
                    Swap(arr,i,j);
                }
            }
            Swap(arr,i+1,high);
            return i+1;

        }

        static void Swap(int[] arr,int i,int j)
        {
            int temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
        }
    }
}
       