def fib(n):
    before ,next_number, actual = 0, 1, 0 
    if n > 1:

        print ("\nFIBONACCI'S SEQUENCE")
        print (30 * "_")    

        for i in range(0, n):
            print (actual)
            before = actual 
            actual = next_number
            next_number = before + next_number
 
    else: 
        print ("Type an natural number, pls ")

fib(int(input("Type a number: ")))


