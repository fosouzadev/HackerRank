namespace CSharp.Arrays
{
    public static class Two2DArrayDS
    {
        public static int HourglassSum(int[][] arr) 
        {
            int i = 0, j = 0;
            int? sum = null;

            for (int s = 0; s <= 3; s++)
            {
                for (int f = 0; f <= 3; f++)
                {
                    int sumAux = arr[i+s][j+f] + 
                                 arr[i+s][j+f+1] + 
                                 arr[i+s][j+f+2] +
                                 arr[i+s+1][j+f+1] +
                                 arr[i+s+2][j+f] + 
                                 arr[i+s+2][j+f+1] + 
                                 arr[i+s+2][j+f+2];
                
                    if (sum == null || sumAux > sum)
                        sum = sumAux;
                }
            }

            if (sum == null)
                return 0;

            return sum.Value;
        }
    }
}