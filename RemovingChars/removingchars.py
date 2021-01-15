finalStr = ""

myStr = input("Enter String: ")

myChar = input("Enter character to remove: ")

for index in range(len(myStr)):
    nextChar = myStr[index:index+1]
    if nextChar != myChar:
        finalStr = finalStr + nextChar

print("Final String is =", finalStr)