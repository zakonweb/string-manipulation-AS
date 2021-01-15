Format = True

String1 = input("Enter the string \'aaaa-999-AAA\' : ")

if len(String1) != 12:
    Format = False

if Format:
    if String1[4:5] != "-" or String1[8:9] != "-":
        Format = False

if Format:
    for pos in range(4):
        chr1 = String1[pos:pos+1]
        if chr1 < "a" or chr1 > "z":
            Format = False

if Format:
    for pos in range(9,12):
        chr1 = String1[pos:pos+1]
        if chr1 < "A" or chr1 > "Z":
            Format = False

if not Format:
    print("The format is invalid.")
else:
    print("The format is valid.")