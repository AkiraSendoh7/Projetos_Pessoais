def inteiro(n):
    for i in range (2,n):
        if n%i == 0:
            print ("Número Primo")
        else:
            print ("Não Primo")
        break

resultado = int(input("Digite um número: "))
inteiro(resultado)