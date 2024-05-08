using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        // crea instancia de la clase tienda
        Tienda espadaDeHierro = new () {nombre = "Espada de Hierro", precio = 1.5f};
        Tienda escudoDeMadera = new () {nombre = "Escudo de Madera", precio = 0.5f} ;
        Tienda pistolaPewPew = new () {nombre = "Pistola:Pew-Pew", precio = 9999f};

        // muestra informacion en la consola
        Debug.Log("Producto: " + espadaDeHierro.nombre + ", Precio: " + espadaDeHierro.precio + " unidades monetarias");
        Debug.Log("Producto: " + escudoDeMadera.nombre + ", Precio: " + escudoDeMadera.precio + " unidades monetarias");
        Debug.Log("Producto: " + pistolaPewPew.nombre + ", Precio: " + pistolaPewPew.precio + " unidades monetarias");
    }
}