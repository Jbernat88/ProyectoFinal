using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectateCollisions : MonoBehaviour
{
    //Para detectar las colisiones
    private void OnCollisionEnter(Collision otherCollider)
    {
        if (gameObject.CompareTag("obstacle") && otherCollider.gameObject.CompareTag("player"))
        {
            Debug.Log($"GAME OVER");
            Time.timeScale = 0;
        }
        if (gameObject.CompareTag("obstacle") && otherCollider.gameObject.CompareTag("proyectil"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
        }
    }

}
