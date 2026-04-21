Algoritmo  EntradasEstadio
    Definir opcion, cantidad Como Entero
    Definir precio, total Como Real
    
    Escribir "Seleccione el sector del estadio:"
    Escribir "1 ? Palco (Q300.00)"
    Escribir "2 ? Tribuna (Q100.00)"
    Escribir "3 ? Preferencia (Q50.00)"
    Escribir "4 ? Generales (Q30.00)"
    Leer opcion
    
    Escribir "Ingrese la cantidad de entradas:"
    Leer cantidad
    
    Segun opcion Hacer
        1:
            precio <- 300
        2:
            precio <- 100
        3:
            precio <- 50
        4:
            precio <- 30
        De Otro Modo:
            Escribir "Opción inválida"
	FinSegun
total <- precio * cantidad	
Escribir "Total a pagar: Q", total
FinAlgoritmo