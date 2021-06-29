using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Jefe2 : MonoBehaviour
{
    public GameObject blanco2;
    public float Velocidad = 5;
    public GameObject GO;
    void Start()
    {
        blanco2 = GameObject.Find("Blanco2");
        GO = GameObject.Find("MCanvas");
    }
    void Update()
    {
        transform.position += transform.forward * Velocidad * Time.deltaTime;
        transform.LookAt(blanco2.transform, Vector3.up);
    }
    void OnTriggerEnter(Collider col)
    {
      
        if (col.gameObject.name == "Bala" || col.gameObject.name == "Player"|| col.gameObject.name == "Blanco2")
        {
            if (col.gameObject.name == "Blanco2") 
            {
                GO.GetComponent<MCanvas>().SetVida(-1);
            }
            Destroy(gameObject);
        }
    }
}
