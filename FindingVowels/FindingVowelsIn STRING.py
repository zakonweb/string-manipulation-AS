a = 0
vowel = ["A","E","I","O","U"]

x = input("Enter String: ")
x = x.upper()

for i in range(len(x)):
    thisChar = x[i:i+1]
    if thisChar in vowel: a += 1

print("Number of vowels:", a)