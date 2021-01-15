hasChanged = False

STR1 = input("Enter String 1: ")
STR1.upper()

STR2 = input("Enter String 2: ")
STR2.upper()

if len(STR1) == len(STR2):
    for C1 in range(len(STR1)):
        nextChar1 = STR1[C1:C1+1]
        STR3 = ""
        hasChanged = False
        for C2 in range(len(STR2)):
            nextChar2 = STR2[C2:C2+1]
            if nextChar2 != nextChar1:
                STR3 = STR3 + nextChar2
            else:
                if not hasChanged:
                    hasChanged = True
                else:
                    STR3 = STR3 + nextChar1
        STR2 = STR3
if STR2 == "":
    print("It is ANAGRAM.")
else:
    print("It is NOT ANAGRAM.")