animals = ['Pig','Dog','Rabbit','Horse','Cat','Elizabetta']

def New_massive(array):
    new_massive = []
    for el in array:
        if len(el) <= 3:
            new_massive.append(el)
    return new_massive

print(New_massive(animals))
