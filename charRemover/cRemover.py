#Initialisation
outString = ""

X = input("Enter String: ")

C = input("Enter character to remove: ")

for Counter in range(len(X)):
    myChar = X[Counter:Counter+1]
    if myChar != C:
        outString = outString + myChar

print("Result:", outString)