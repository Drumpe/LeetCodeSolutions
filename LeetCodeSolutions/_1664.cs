namespace LeetCodeSolutions
{
    public class _1664
    {
        public int WaysToMakeFair(int[] nums)
        {
            //Att räkna på varje array, utan i, för sig gav Time Limit Exceeded
            //Så funderade på hur man kunde sumera en gång och sedan flytta värden
            int result = 0;
            int[] sum = { 0, 0 }; //Summan : Jämna i [0] udda i [1]
            for (int i = 0; i < nums.Length; i++) //Börjar med att sumera arrayn
            {
                sum[i % 2] += nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i % 2] -= nums[i]; //Tar bort nums[i] 
                if (sum[0] == sum[1])
                {
                    result++;
                }
                sum[(i % 2) == 0 ? 1 : 0] += nums[i]; //Lägger till nums[i], flippar udda - jämn
            }
            return result;
        }
    }
}