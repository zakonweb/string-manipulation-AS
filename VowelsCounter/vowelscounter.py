vowels = "aA"
vCount = 0

myStr = input("Enter string to look for vowels: ")

for counter in myStr:
    if counter in vowels:
        vCount = vCount + 1

print("Number of vowels in the given string = ", vCount)