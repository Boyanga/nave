using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Jefe : MonoBehaviour
{
    public float Velocidad = 5;
    public GameObject blanco;

    void Start()
    {
        blanco = GameObject.Find("Blanco1");
    }
    void Update()
    {
        transform.position += transform.forward * Velocidad * Time.deltaTime;
        transform.LookAt(blanco.transform, Vector3.up);
    }
    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "Bala" || col.gameObject.tag == "Player" || col.gameObject.tag == "Blanco1")
        {
            Destroy(gameObject);
        }
    }
}
