using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public Cubo cubo;
    public CanvasManager canvasManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cuboColisionado = collision.GetComponent<Cubo>();

        if (cuboColisionado != null)
        {
            canvasManager.MostrarMensaje("¡Hola " + cubo.Nombre + "!");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.OcultarMensaje();
    }
}
