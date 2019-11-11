#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    int maxArea(vector<int>& height)
    {
        int nCurrentLeft = 0;
        int nCurrentRight = height.size() - 1;
        int nMaxArea = 0;

        while (nCurrentLeft < nCurrentRight)
        {
            if (height[nCurrentLeft] <= height[nCurrentRight])
            {
                int nCurrentArea = height[nCurrentLeft] * (nCurrentRight - nCurrentLeft);

                if (nCurrentArea > nMaxArea)
                {
                    nMaxArea = nCurrentArea;
                }

                nCurrentLeft++;
            }
            else
            {
                int nCurrentArea = height[nCurrentRight] * (nCurrentRight - nCurrentLeft);

                if (nCurrentArea > nMaxArea)
                {
                    nMaxArea = nCurrentArea;
                }

                nCurrentRight--;
            }
        }

        return nMaxArea;
    }
};

int main()
{
    vector<int> testCase1({1,8,6,2,5,4,8,3,7});
    vector<int> testCase2({2,1});
    vector<int> testCase3({2,3,10,5,7,8,9});

    Solution *pMySolution = new Solution;
    std::cout << "Test Case 1: Max Area was: " << pMySolution->maxArea(testCase1) <<  std::endl;
    std::cout << "Test Case 2: Max Area was: " << pMySolution->maxArea(testCase2) <<  std::endl;
    std::cout << "Test Case 3: Max Area was: " << pMySolution->maxArea(testCase3) <<  std::endl;
    delete pMySolution;
    return 0;
}
