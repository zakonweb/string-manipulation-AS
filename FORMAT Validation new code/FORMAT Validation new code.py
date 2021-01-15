import sys

X = input("Enter X, Format (999+AAAA+aa!)  : ")

if len(X) != 12:
    print("Invalid Format")
    sys.exit

if X[3:4] != "+" or X[8:9] != "+" or X[11:12] != "!":
    print("Invalid Format")
    sys.exit()

for Pos in range(3):
    C = X[Pos:Pos+1]
    if C < "0" or C > "9":
        print("Invalid Format")
        sys.exit()

for Pos in range(4,8):
    C = X[Pos:Pos+1]
    if C < "A" or C > "Z":
        print("Invalid Format")
        sys.exit()

for Pos in range(9,11):
    C = X[Pos:Pos+1]
    if C < "a" or C > "z":
        print("Invalid Format")
        sys.exit()

print("Valid Format")