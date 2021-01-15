#Initialistaion
cCount = 0

X = input("Enter string to search in: ")

C = input("Enter character to look and count for: ")

for counter in range(len(X)):
    myChar = X[counter:counter+1]
    if myChar.upper() == C.upper():
        cCount = cCount + 1

print(cCount)