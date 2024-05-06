using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public TMP_Text mensajeTexto;

    public void MostrarMensaje(string mensaje)
    {
        mensajeTexto.text = mensaje;
        mensajeTexto.gameObject.SetActive(true);
    }
    public void OcultarMensaje()
    {
        mensajeTexto.gameObject.SetActive(false);
    }
}
