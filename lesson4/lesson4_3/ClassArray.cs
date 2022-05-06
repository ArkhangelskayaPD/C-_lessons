using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson4_3
{
    internal class ClassArray
    {
        int[] a;


        public ClassArray(int n, int start, int step)
        {
            int i;
            a = new int[n];
            a[0] = start;
            for (i = 1; i < n; i++)

                a[i] = a[i - 1] + step;

        }

        public override string ToString()
        {
            string str = "";
            foreach (int v in a)
                str = str + v + " ";
            return str;
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }

        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * -1;
            }
        }

        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }

        public int MaxNumber
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }



        public ClassArray(string FileName)
        {
            if (File.Exists(FileName))
            {
                string[] RF = File.ReadAllLines(FileName);
                a = new int[RF.Length];
                for (int i = 0; i < RF.Length; i++)
                    a[i] = int.Parse(RF[i]);
            }
        }


    }
}
