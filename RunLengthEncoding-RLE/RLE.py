def RLDecode(i):
    rCount = ""
    outP = ""
    for loop0 in range(len(i)):
        m = i[loop0:loop0+1]
        if '0'<=m<='9': rCount += m
        else:
            if len(rCount) > 0:
                for a in range(int(rCount)):
                    outP += m
                rCount = ""
            else:
                outP += m
    return outP

def RLEncode(i):
    tmp1 = i[:1]
    tmp2 = tmp1
    rCount = 1
    outP = ""

    for Loop0 in range(1,len(i)):
        tmp1 = i[Loop0:Loop0+1]
        if tmp1 != tmp2:
            outP += str(rCount).strip() + tmp2
            tmp2 = tmp1
            rCount = 1
        else:
            rCount += 1

    outP += str(rCount).strip()
    outP += tmp2
    return outP


initial = input("Type something: ")

encoded = RLEncode(initial)
decoded = RLDecode(encoded)

print("Initial string:", initial)
print("Compressed/Encoded string using RLE:", encoded)
print("Compressed/Encoded string using RLE:", decoded)