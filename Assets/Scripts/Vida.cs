using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public GameObject GO;
    //public int Vidas = 5;
    void Start()
    {
        GO = GameObject.Find("MCanvas");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Meteoro") || col.CompareTag("Enemigo") || col.CompareTag("BMala"))
        {
            GO.GetComponent<MCanvas>().SetVida(1);
        }
    }
}
