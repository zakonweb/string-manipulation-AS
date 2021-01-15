myArr = []
for x in range(10):
    myArr.append("")

mySTR = input("Enter CamelCase string: ")

ArrFinished = False
i = 0
myWord = mySTR[:1]

for j in range(1,len(mySTR)):
    myChar = mySTR[j:j+1]
    if myChar >= "A" and myChar <= "Z":
        myArr[i] = myWord
        myWord = myChar
        i += 1
        if i > 10:
            ArrFinished = True
            break
    else:
        myWord = myWord + myChar

if ArrFinished == False: myArr[i] = myWord

for j in range(i+1,10):
    myArr[j] = "(Empty)"

for j in range(10):
    print(myArr[j])