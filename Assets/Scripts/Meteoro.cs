using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Meteoro : MonoBehaviour

{
    public float Velocidad =2;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.back * Velocidad + Vector3.right * Random.Range(-1,1);
        rb.angularVelocity = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    void Colision()
    {
        print("Asteroide  colision");
    }
    
}
