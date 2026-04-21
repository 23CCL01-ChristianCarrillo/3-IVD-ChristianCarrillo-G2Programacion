Algoritmo CalculadoraTrigonometrica
    Definir angulo, radianes, resultado Como Real
    Definir opcion Como Entero
    
    Escribir "Ingrese el ángulo en grados:"
    Leer angulo
    
    // Convertir a radianes
    radianes <- angulo * PI / 180
    
    Escribir "Seleccione la función:"
    Escribir "1 ? Seno"
    Escribir "2 ? Coseno"
    Escribir "3 ? Tangente"
    Leer opcion
    
    Segun opcion Hacer
        1:
            resultado <- Sen(radianes)
            Escribir "Seno: ", resultado
        2:
            resultado <- Cos(radianes)
            Escribir "Coseno: ", resultado
        3:
            resultado <- Tan(radianes)
            Escribir "Tangente: ", resultado
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinAlgoritmo