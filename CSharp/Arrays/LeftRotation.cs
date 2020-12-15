namespace CSharp.Arrays
{
    public static class LeftRotation
    {
        public static int[] RotLeft(int[] a, int d) 
        {
            int[] res = new int[a.Length];
            
            for (int i = 0; i < a.Length; i++)
            {
                int indice = i - d + a.Length;

                if (indice >= a.Length)
                    indice = indice - a.Length;

                res[indice] = a[i];
            }
            
            return res;
        }
    }
}