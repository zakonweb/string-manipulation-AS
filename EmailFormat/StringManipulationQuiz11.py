def isEmailValid(Eadd):
    atCounter = 0

    for a in range(len(Eadd)):
        ch = Eadd[a:a+1]
        if ch == "@": atCounter = atCounter + 1

    if atCounter > 1 or Eadd[:1] == "@" or Eadd.find("@") >= (len(Eadd) - 4):
        return False
    else:
        return True

print(isEmailValid(input()))