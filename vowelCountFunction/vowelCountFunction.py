def vowelCount(s):
    c = 0
    for a in range(len(s)):
        ch = s[a:a + 1]
        if ch in "aeiouAEIOU": c = c + 1
    return c


# There is no case in python so here's an alternative method using count function
# You don't need to pick a char separately in python as described in vowelCount1. Use for-in loop instead.
def vowelCount1(s):
    c = 0
    for a in "aeiouAEIOU":
        c += s.count(a)
    return c


def vowelCount2(s):
    c = 0
    for a in range(len(s)):
        ch = s[a:a + 1]
        if ch == "a" or ch == "e" or ch == "i" or ch == "o" or ch == "u": c = c + 1
        if ch == "A" or ch == "E" or ch == "I" or ch == "O" or ch == "U": c = c + 1
    return c


myStr = input("Enter string to find vowels: ")

print("Vowel count =", vowelCount(myStr))