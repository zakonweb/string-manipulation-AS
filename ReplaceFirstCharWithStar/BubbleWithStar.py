S2 = input("Enter a statement: ")
S2F = S2[:1]
print(S2F, end="")
for COUNT in range(len(S2)-1):
    myChar = S2[COUNT+1:COUNT+2]
    if myChar == S2F:
        myChar = "*"
    print(myChar, end="")