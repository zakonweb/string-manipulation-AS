myStr = input("Enter phrase to check Pangram: ")

if len(myStr) < 26:
    print("It is not Pangram.")
else:
    for b in range(65,91):
        isFound = False
        if chr(b) in myStr.upper():
            isFound = True
        if isFound == False:
            print("It is not Pangram.")
            break
if isFound == True:
    print("It is a Pangram.")