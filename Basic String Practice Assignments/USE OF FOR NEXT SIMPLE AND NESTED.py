a = 1
while a <= 5:
    print(a)
    a = a + 1

input()

for rows in range(1,6):
    for col in range(1,6):
        print(rows, end="")
    print("")
input()

for rows in range(1,6):
    for col in range(1,rows+1):
        print(col, end="")
    print("")
input()

for rows in range(5,0,-1):
    for col in range(1,rows+1):
        print(rows, end="")
    print("")
input()

for rows in range(5,0,-1):
    for col in range(rows,0,-1):
        print(col, end="")
    print("")
input()