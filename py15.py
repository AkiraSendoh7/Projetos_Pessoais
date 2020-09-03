def numero (a,b,c):
    if a == b == c:
        soma = 3 * a
        return 3 * soma
    else:
        soma = a + b + c
        return soma

n1 = int(input("n1: "))
n2 = int(input("n2: "))
n3 = int(input("n3: "))

print (numero(n1,n2,n3))