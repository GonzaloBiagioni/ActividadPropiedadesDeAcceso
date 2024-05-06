using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda
{
    // propiedad de acceso automatico para nombre y precio
    public string nombre { get; set; }
    public float precio { get; set; }
}

public class GameController : MonoBehaviour
{
    void Start()
    {
        // crea instancia de la clase tienda
        Tienda espadaDeHierro = new Tienda {nombre = "Espada de Hierro", precio = 1.5f};
        Tienda escudoDeMadera = new Tienda {nombre = "Escudo de Madera", precio = 0.5f} ;
        Tienda pistolaPewPew = new Tienda {nombre = "Pistola:Pew-Pew", precio = 9999f};

        // muestra informacion en la consola
        Debug.Log("Producto: " + espadaDeHierro.nombre + ", Precio: " + espadaDeHierro.precio + " unidades monetarias");
        Debug.Log("Producto: " + escudoDeMadera.nombre + ", Precio: " + escudoDeMadera.precio + " unidades monetarias");
        Debug.Log("Producto: " + pistolaPewPew.nombre + ", Precio: " + pistolaPewPew.precio + " unidades monetarias");
    }
}