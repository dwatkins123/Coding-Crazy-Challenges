package main

import (
	"fmt"
	"strconv"
)

func maxArea(height []int) int {
	var CurrentLeft int = 0
	var CurrentRight int = len(height) - 1
	var MaxArea int = 0

	for CurrentLeft < CurrentRight {
		if height[CurrentLeft] < height[CurrentRight] {
			var CurrentArea int = height[CurrentLeft] * (CurrentRight - CurrentLeft)

			if CurrentArea > MaxArea {
				MaxArea = CurrentArea
			}

			CurrentLeft++
		} else {
			var CurrentArea int = height[CurrentRight] * (CurrentRight - CurrentLeft)

			if CurrentArea > MaxArea {
				MaxArea = CurrentArea
			}

			CurrentRight--
		}
	}

	return MaxArea
}

func main() {
	var testCase1 []int = []int{1, 8, 6, 2, 5, 4, 8, 3, 7}
	var testCase2 []int = []int{2, 1}
	var testCase3 []int = []int{2,3,10,5,7,8,9};

	fmt.Println("Test Case 1: Max Area was: " + strconv.Itoa(maxArea(testCase1)))
	fmt.Println("Test Case 2: Max Area was: " + strconv.Itoa(maxArea(testCase2)))
	fmt.Println("Test Case 3: Max Area was: " + strconv.Itoa(maxArea(testCase3)))
}
