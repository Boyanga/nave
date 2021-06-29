using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Velocidad = 20;
   
    void Start()
    {
        Destroy(gameObject, 3);
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
        Destroy(gameObject);  
    }   
    void Update()
    {
        transform.position += transform.up * Velocidad * Time.deltaTime;
    }
}
