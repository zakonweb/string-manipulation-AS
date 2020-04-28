import sys

def print_words(fn):
    f = open(fn,'r')
    content = f.read()
    f.close()

    words = sorted(content.split())

    d = {}   # d = {}

    for word in words:
        if word in d:
            d[word] += 1
        else:
            d[word] = 1

    for w in d.keys():
        print(w + " " + str(d[w]))

def main():
    #if len(sys.argv) != 3:
    #  print("usage: ./wordcount.py {--count | --topcount} file")
    #  sys.exit(1)

    #option = sys.argv[1]
    #filename = sys.argv[2]
    #if option == '--count':q
    #  print_words(filename)
    print_words("insertSort.py")
    #elif option == '--topcount':
    #  print_top(filename)
    #else:
    #  print ('unknown option: ' + option)
    #  sys.exit(1)

if __name__ == '__main__':
    main()
