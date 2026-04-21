Algoritmo CompraImpresoras
    Definir cantidad Como Entero
    Definir precioBase, precioIVA, subtotal, descuento, total Como Real
    Definir opcion Como Entero
    Definir formaPago Como Cadena
    
    precioBase <- 650
    precioIVA <- precioBase * 1.12
    
    Escribir "Ingrese la cantidad de impresoras:"
    Leer cantidad
    
    Escribir "Seleccione la forma de pago:"
    Escribir "1 ? Efectivo (10%)"
    Escribir "2 ? Tarjeta de crédito (5%)"
    Escribir "3 ? Vale de regalo (15%)"
    Leer opcion
    
    subtotal <- cantidad * precioIVA
    
    Segun opcion Hacer
        1:
            descuento <- subtotal * 0.10
            formaPago <- "Efectivo"
        2:
            descuento <- subtotal * 0.05
            formaPago <- "Tarjeta de crédito"
        3:
            descuento <- subtotal * 0.15
            formaPago <- "Vale de regalo"
        De Otro Modo:
            Escribir "Opción inválida"
FinSegun

total <- subtotal - descuento

Escribir "Cantidad: ", cantidad
Escribir "Precio unitario con IVA: Q", precioIVA
Escribir "Total sin descuento: Q", subtotal
Escribir "Forma de pago: ", formaPago
Escribir "Descuento: Q", descuento
Escribir "Total a pagar: Q", total
FinAlgoritmo