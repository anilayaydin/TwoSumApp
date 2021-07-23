using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{2,7,9,11};
            int target=9;
            int[] resultIndices = new int[2];

            resultIndices=TwoSum(nums,target);
            
            foreach(var indice in resultIndices)
                System.Console.WriteLine(indice);
        }

        public static int[] TwoSum(int[] nums, int target) {

            int remainingNum=0;
            int remainingNumOneIndice=0;
            int remainingNumTwoIndice=0;
            int[] indices = new int[2];

            for(int i=0;i<nums.Length;i++)
            {
                remainingNum=target-nums[i];

                if(Array.IndexOf(nums,remainingNum)!=-1)
                {
                    remainingNumOneIndice=i;
                    remainingNumTwoIndice=Array.IndexOf(nums,remainingNum);
                    indices= new int[2] {remainingNumOneIndice,remainingNumTwoIndice};
                    break;
                }
            }       
            
            return indices;
        }
    }
}
