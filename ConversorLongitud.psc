Algoritmo ConversorLongitud
    Definir opcion1, opcion2 Como Entero
    Definir valor, metros, resultado Como Real
	Escribir "Ingrese el valor a convertir:"
    Leer valor
    Escribir "Seleccione la unidad de origen:"
    Escribir "1 ? Metros"
    Escribir "2 ? Pies"
    Escribir "3 ? Centímetros"
    Escribir "4 ? Pulgadas"
    Leer opcion1
    // Convertir a metros (unidad base)
    Segun opcionOrigen Hacer
        1:
            metros <- valor
        2:
            metros <- valor * 0.3048
        3:
            metros <- valor / 100
        4:
            metros <- valor * 0.0254
        De Otro Modo:
            Escribir "Opción inválida"
FinSegun

Escribir "Seleccione la unidad de destino:"
Escribir "1 ? Metros"
Escribir "2 ? Pies"
Escribir "3 ? Centímetros"
Escribir "4 ? Pulgadas"
Leer opcionDestino

// Convertir desde metros a la unidad destino
Segun opcion2 Hacer
	1:
		resultado <- metros
	2:
		resultado <- metros / 0.3048
	3:
		resultado <- metros * 100
	4:
		resultado <- metros / 0.0254
	De Otro Modo:
		Escribir "Opción inválida"
FinSegun
Escribir "Resultado: ", resultado
FinAlgoritmo