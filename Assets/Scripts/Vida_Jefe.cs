using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida_Jefe : MonoBehaviour
{
    public int vida = 100;
    void OnTriggerEnter(Collider col)
    {
     if (col.gameObject.tag == "Bala")
     {
        vida = vida - 1;
        if (vida == 0)
        {
            Destroy(gameObject);
                SceneManager.LoadScene("Inicio");
            }
     }
    }
}
