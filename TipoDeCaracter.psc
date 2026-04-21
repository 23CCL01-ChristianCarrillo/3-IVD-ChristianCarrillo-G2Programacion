Algoritmo TipoDeCaracter
    Definir c Como Caracter    
    Escribir "Ingrese un carácter:"
    Leer c
    
    Segun c Hacer
        "a","e","i","o","u","A","E","I","O","U":
            Escribir "Es una vocal"
        "0","1","2","3","4","5","6","7","8","9":
            Escribir "Es un dígito"
        De Otro Modo:
            Escribir "No es vocal ni dígito"
    FinSegun
FinAlgoritmo