Highest = 0
myChar = ""

Phrase = input("Enter Phrase: ")

for i in range(len(Phrase)):
    nextChar = Phrase[i:i+1]
    count = 0
    for j in range(len(Phrase)):
        thisChar = Phrase[j:j+1]
        if thisChar == nextChar: count = count + 1

    if count > Highest:
        Highest = count
        myChar = nextChar

print(myChar, "appreared", Highest, "number of times.")