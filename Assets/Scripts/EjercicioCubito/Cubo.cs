using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float velocidad;

    [SerializeField]
    private string nombre = "Cubito";

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                Debug.Log("El nombre no puede ser nulo ni una cadena vacía.");
            }
        }
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float speed_x = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * velocidad * speed_x * Time.deltaTime);
    }

    public void CambiarNombre(string nuevoNombre)
    {
        Nombre = nuevoNombre;
    }
}
