def list_number(n):
    c = 0 
    for numero in n:
        if numero == 4:
            c = c + 1
    return c

serie = list()
for i in range (0,10):
    n = int(input("Digite um valor: "))
    if i == 0 or n > serie[-1]:
        serie.append(n)
    else : 
        pos = 0 
        while pos < len(serie): 
            if n <= serie[pos] :
                serie.insert(pos, n)
                break 
            pos += 1 

print ("\n")
print ("O número de 4's é: ")
print (list_number(serie))