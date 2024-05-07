using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public Cubo cubo;
    public CanvasManager canvasManager;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Cubo cuboColisionado = collision.GetComponent<Cubo>();

        if (cuboColisionado != null)
        {
            anim.SetBool("RectanguloUp", true);
            canvasManager.MostrarMensaje("¡Hola " + cubo.Nombre + "!");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("RectanguloUp", false);
        canvasManager.OcultarMensaje();
    }
}
