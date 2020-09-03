def ask_about(name, age):
    ano = 2020 - age + 100
    print (f"Olá {name}, você terá 100 anos no ano {ano}")

nome = input("Digite o nome: ")
idade = int(input("Digite a sua idade: "))
ask_about(nome, idade)