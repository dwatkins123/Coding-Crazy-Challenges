import Cocoa

class Solution {
    func maxArea(_ height: [Int]) -> Int {
        var currentLeft = 0
        var currentRight = height.count - 1
        var maxArea = 0

        while currentLeft < currentRight {
            if height[currentLeft] <= height[currentRight] {
                let currentArea = height[currentLeft] * (currentRight - currentLeft)

                if currentArea > maxArea {
                    maxArea = currentArea
                }

                currentLeft += 1
            }
            else {
                let currentArea = height[currentRight] * (currentRight - currentLeft)

                if currentArea > maxArea {
                    maxArea = currentArea
                }

                currentRight -= 1
            }
        }

        return maxArea
    }
}

var testCase1: [Int] = [1, 8, 6, 2, 5, 4, 8, 3, 7]
var testCase2: [Int] = [2, 1]
var testCase3: [Int] = [2, 3, 10, 5, 7, 8, 9]

let mySolution = Solution()
print("Test Case 1: Max Area was: ", mySolution.maxArea(testCase1))
print("Test Case 2: Max Area was: ", mySolution.maxArea(testCase2))
print("Test Case 3: Max Area was: ", mySolution.maxArea(testCase3))
