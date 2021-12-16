using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    //Cuando el proyectil supere los limites seleccionados se destruirán.
    private float xmax = 300f;
    private float ymax = 300f;
    private float zmax = 300f;

    // Update is called once per frame
    void Update()
    {
        //El proyectil se destruye cuando se supera el limite establecido
        if (transform.position.x > xmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xmax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > ymax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zmax)
        {
            Destroy(gameObject);
        }
    }
}
