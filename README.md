# [Sistemas de Gestión de Asientos de Vuelo](https://github.com/OctavioReinoso/trabajoPractico3)

## Descripción General
Este programa implementa un sistema simple para la gestión de reservas de asientos en un vuelo con un total de 60 asientos. Permite realizar varias operacoines como la reserva, cancelación, consulta de estado de los asientos y búsqueda de un asiento en particular. Todas las interacciones se realizana través de un menú presentado al usuario en la consola.

## Funcionalidades principales
1. Reservar un asiento: Permite elegir el número de asiento que quieres reservar (del 0 al 59). Si el asiento está libre, el programa lo marca como ocupado.
2. Cancelar una reserva: Si ya tienes un asiento reservado pero quieres cancelarlo, se usa esta opción. El programa vuelve a marcar el asiento como disponible.
3. Ver el estado del vuelo: Permite ver el estado de cada uno de los 60 asientos del avión. El programa te dice si están ocupados o libres.
4. Cantidad de asientos ocupados y libres: Aquí puedes consultar cuántos asientos están ocupados y cuantos siguen disponibles.
5. Buscar un asiento en específico: Si tienes un asiento en mente y quieres saber si está libre, puedes usar esta opción para consultar el estado de un asiento en específico.

## ¿Cómo funciona?
* El programa esta diseñado para ser muy sencillo. Al ejecutarlo, muestra el menú donde se puede elegir que hacer(reservar, cancelar, etc). Al elegir una opción, el programa pedirá la información necesaria (como el numero de asiento) y luego ejecuta la acción que hayas elegido.
* Todo el programa gira alrededor de un arreglo donde se guarda el estado de cada asiento: **0**, si está libre y **1**, si está ocupado.
* Cuando se reserva un asiento, cambia el valor del arreglo, y lo mismo pasa cuando se cancela una reserva.

## Cosas a tener en cuenta
* Los asientos van del número **0** al **59**, así que si ingresas un número fuera de ese rango, el programa indicará que es inválido.
* El programa está pensado para ser muy directo: reservar, cancelar, o consultar acerca del estado de los asientos.
* Siempre que se termina una operación, el menú vuelve a aparecer para que puedas elegir otra acción o salir del programa.

## Integrantes 
**Cornejo Lucas. Martinez Candela. Peralta Sofia. Reinoso Octavio.**

### **Trabajo Practico 3 realizado para la materia de Programación I. Tecnicatura Superior en Desarrollo de Software, Quality ISAD.**
