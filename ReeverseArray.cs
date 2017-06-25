using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects
{
    public class ReverseArray
    {
        private int[] arr;

        public ReverseArray(int[] vals)
        {
            arr = vals;
        }

        public void Print()
        {
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public void Reverse()
        {
            int mid = (arr.Length - 1) / 2;
            for (int itr = 0; itr <= mid; itr++)
            {
                this.Swap(ref arr[itr], ref arr[arr.Length - 1 - itr]);
            }
        }

        private void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
