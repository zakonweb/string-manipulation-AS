alphaStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
isPangram = True

str1 = input("Enter String: ")
str1 = str1.upper()

for Count in alphaStr:
    if Count not in str1:
        isPangram = False
        break

if isPangram == True:
    print("Sentence entered is Pangram.")
else:
    print("Sentence Entered is NOT pangram.")