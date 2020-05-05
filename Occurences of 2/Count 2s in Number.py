"""
Count the number of 2s as digit in all numbers from 0 to n.

Input:
The first line of input contains an integer T denoting the number of test cases. Then T test cases follow. Each test case contains the input integer n.

Output:
Print the count of the number of 2s as digit in all numbers from 0 to n.

Constraints:
1<=T<=100
1<=N<=10^5

Example:
Input:
2
22
100

Output:
6
20
"""

testCases = 0
count0 = 0
count1 = 0
countOf2 = 0
inputCount = 0
numStr = ""
i = ""
ansLst = []

print("Input:")
testCases = int(input())

for count0 in range(testCases):
    inputCount = int(input())
    countOf2 = 0

    for count1 in range(inputCount+1):
        numStr = str(count1)
        for i in numStr:
            if i == "2":
                countOf2 += 1
    if countOf2 > 0:
        ansLst.append(countOf2)

print("Output:")
for i in ansLst:
    print(i)
