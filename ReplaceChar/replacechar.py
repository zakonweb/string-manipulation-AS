Str2 = ""

Str1 = input("Enter String: ")

Char1 = input("Enter character to remove: ")

Char2 = input("Enter the character to replace: ")

for Counter in range(len(Str1)):
    nextChar = Str1[Counter:Counter+1]
    if nextChar == Char1:
        nextChar = Char2
    Str2 = Str2 + nextChar

print("Final String =", Str2)