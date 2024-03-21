namespace AlgoTest
{
    public class SearchAlgorithms
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr">Sorted Array</param>
        /// <param name="n">Number to find it form an array</param>
        /// <returns></returns>
        public int BinarySearch(int[] arr, int n)
        {
            int left = 0;
            int right = arr.Length-1;
            while(left <= right)
            {
                var m = (left+right)/2;
                if(arr[m]==n)
                    return m;
                if(arr[m]>=n)
                    right=m-1;
                else
                    left=m+1;
            }
            return -1;
        }
    }
}
