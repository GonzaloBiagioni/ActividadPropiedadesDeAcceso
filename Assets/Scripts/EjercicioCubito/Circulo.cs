using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public Cubo cubo;  
    public CanvasManager canvasManager;
    private Animator anim;
    private bool nombreCambiado = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cuboColisionado = collision.GetComponent<Cubo>();

        if (cuboColisionado != null)
        {
            if (cuboColisionado.Nombre == "Cubito" && !nombreCambiado)
            {
                cuboColisionado.CambiarNombre("Circulo");
                nombreCambiado = true;

                canvasManager.MostrarMensaje("No me gusta tu nombre, ahora te llamaras Circulo");
                anim.Play("AnimacionSaludo");
            }
            else
            {
                canvasManager.MostrarMensaje("¡Hola, ¿qué tal?");
                anim.Play("AnimacionAlternativa");
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.OcultarMensaje();
    }
}