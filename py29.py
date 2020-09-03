def numbers(n):
    x = range(2,n+1)
    for elem in x:
        if (n%elem == 0):
            print (elem)

numero = int(input("Digite o número: "))
numbers(numero)