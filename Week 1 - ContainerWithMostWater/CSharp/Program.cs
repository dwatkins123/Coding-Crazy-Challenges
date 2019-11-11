using System;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int CurrentLeft = 0;
            int CurrentRight = height.Length - 1;
            int CurrentMaxArea = 0;

            while (CurrentLeft < CurrentRight)
            {
                if (height[CurrentLeft] <= height[CurrentRight])
                {
                    int CurrentArea = height[CurrentLeft] * (CurrentRight - CurrentLeft);

                    if (CurrentArea > CurrentMaxArea)
                    {
                        CurrentMaxArea = CurrentArea;
                    }

                    CurrentLeft++;
                }
                else
                {
                    int CurrentArea = height[CurrentRight] * (CurrentRight - CurrentLeft);

                    if (CurrentArea > CurrentMaxArea)
                    {
                        CurrentMaxArea = CurrentArea;
                    }

                    CurrentRight--;
                }
            }

            return CurrentMaxArea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution mySolution = new Solution();
            int[] TestCase1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] TestCase2 = { 2, 1 };
            int[] TestCase3 = { 2, 3, 10, 5, 7, 8, 9 };

            Console.WriteLine("Test Case 1: Max Area was: " + mySolution.MaxArea(TestCase1));
            Console.WriteLine("Test Case 2: Max Area was: " + mySolution.MaxArea(TestCase2));
            Console.WriteLine("Test Case 3: Max Area was: " + mySolution.MaxArea(TestCase3));

        }
    }
}
