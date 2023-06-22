using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strivers_SDE_Sheet_Challenge.Easy.Arrays
{
    public class Set_Matrix_Zeroes
    {
        public static int[][] Sol(int[][] a)
        {
            int r = a.Length;
            int c = a[0].Length;
            if (r <= 0 || (r == 1 && c == 1)) return a;
            List<int> ro = new();
            List<int> col = new();
            for (int i = 0; i < r; i++)
                for (int j = 0; j < a[i].Length; j++)
                    if (a[i][j] == 0)
                    {
                        if (!ro.Contains(i))
                            ro.Add(i);
                        if (!col.Contains(j))
                            col.Add(j);
                    }
            if (!(col.Count == c) && ro.Count > 0)
                    foreach (int i in ro)
                        for (int j = 0; j < a[i].Length; j++)
                            a[i][j] = 0;
            if (((ro.Count == r ) && (col.Count == c)) || col.Count > 0)
                foreach (int i in col)
                    for (int j = 0; j < r; j++)
                        a[j][i] = 0;
            return a;
        }
    }
}
