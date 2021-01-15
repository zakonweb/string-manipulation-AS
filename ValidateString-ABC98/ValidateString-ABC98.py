def validateString(MyStr):
    if len(MyStr) != 5:
        return False
    for i in range(3):
        ch = MyStr[i:i+1]
        if ch < "A" or ch > "Z": return False

    for i in range(3,5):
        ch = MyStr[i:i+1]
        if ch < "0" or ch > "9": return False

    return True

inputStr = input()
ifValidStr = validateString(inputStr)
if ifValidStr:
    print("String is Valid.")
else:
    print("String is invalid!")