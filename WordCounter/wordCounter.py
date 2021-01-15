wordCount = 0

myStr = input("Enter string to count words: ")

for Counter in range(len(myStr)):
    myChar = myStr[Counter:Counter+1]
    if myChar == " ":
        wordCount = wordCount + 1

if myStr[-1:] != " ":
    wordCount = wordCount + 1

print("The word count in sentence \"", myStr, "\" is =", wordCount)