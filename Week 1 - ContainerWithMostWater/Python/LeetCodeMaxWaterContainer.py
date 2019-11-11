from typing import List


class Solution:
    def maxarea(self, height: List[int]) -> int:
        currentleft = 0
        currentright = len(height) - 1
        maxarea = 0

        while currentleft < currentright:
            if height[currentleft] <= height[currentright]:
                currentarea = height[currentleft] * (currentright - currentleft)

                if currentarea > maxarea:
                    maxarea = currentarea

                currentleft += 1
            else:
                currentarea = height[currentright] * (currentright - currentleft)

                if currentarea > maxarea:
                    maxarea = currentarea

                currentright -= 1
        return maxarea


TestCase1 = [1, 8, 6, 2, 5, 4, 8, 3, 7]
TestCase2 = [2, 1]
TestCase3 = [2, 3, 10, 5, 7, 8, 9]

MySolution = Solution()

print("Test Case 1: Max Area was {}".format(MySolution.maxarea(TestCase1)))
print("Test Case 2: Max Area was {}".format(MySolution.maxarea(TestCase2)))
print("Test Case 3: Max Area was {}".format(MySolution.maxarea(TestCase3)))
