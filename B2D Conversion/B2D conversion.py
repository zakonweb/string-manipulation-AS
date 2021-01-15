Magnitude = 0
validBinaryNumber = True

STR1 = input("Enter Binary Number: ")

if len(STR1) < 1 or len(STR1) > 8:
    validBinaryNumber = False

if validBinaryNumber:
    for count in range(len(STR1)):
        bit = STR1[count:count + 1]
        if bit < "0" or bit > "1":
            validBinaryNumber = False
            break

if not validBinaryNumber:
    print("Not a valid binary number...")

if validBinaryNumber:
    for count in range(len(STR1)):
        Position = (8 - len(STR1)) + count
        bit = STR1[count:count + 1]

        if Position == 7 and bit == "1":
            Magnitude = Magnitude + 1
        if Position == 6 and bit == "1":
            Magnitude = Magnitude + 2
        if Position == 5 and bit == "1":
            Magnitude = Magnitude + 4
        if Position == 4 and bit == "1":
            Magnitude = Magnitude + 8
        if Position == 3 and bit == "1":
            Magnitude = Magnitude + 16
        if Position == 2 and bit == "1":
            Magnitude = Magnitude + 32
        if Position == 1 and bit == "1":
            Magnitude = Magnitude + 64
        if Position == 0 and bit == "1":
            Magnitude = Magnitude + 128
    print(STR1, "=", Magnitude)