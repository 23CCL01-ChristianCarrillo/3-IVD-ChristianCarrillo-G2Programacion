Algoritmo CalculadoraBasica
    Definir num1, num2, resultado Como Real
    Definir opcion Como Entero
    
    Escribir "Ingrese el primer número:"
    Leer num1
    
    Escribir "Ingrese el segundo número:"
    Leer num2
    
    Escribir "Seleccione una opción:"
    Escribir "1 ? Sumar"
    Escribir "2 ? Restar"
    Escribir "3 ? Multiplicar"
    Escribir "4 ? Dividir"
    Leer opcion
    
    Segun opcion Hacer
        1:
            resultado <- num1 + num2
            Escribir "Resultado: ", resultado
        2:
            resultado <- num1 - num2
            Escribir "Resultado: ", resultado
        3:
            resultado <- num1 * num2
            Escribir "Resultado: ", resultado
        4:
            Si num2 <> 0 Entonces
                resultado <- num1 / num2
                Escribir "Resultado: ", resultado
            SiNo
                Escribir "Error: No se puede dividir entre cero"
            FinSi
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinAlgoritmo