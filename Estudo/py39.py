def get_names(name):
    names = list()

    for i in name:
        if i not in names:
            names.append(i)
    return names

def get_list(name):
    return list(set(name))

a = [1,1,2,3,5]
print (a)
print (get_names(a))
print (get_list(a))
