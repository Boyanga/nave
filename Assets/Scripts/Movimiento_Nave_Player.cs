using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movimiento_Nave_Player : MonoBehaviour
{
    Rigidbody rb;
    public float velocidad = 8;

    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    void Update()
    {
        Vector3 DireccionX = Input.GetAxis("Horizontal") * Vector3.right;
        Vector3 DireccionsZ = Input.GetAxis("Vertical") * Vector3.forward;

        Vector3 Direccion = DireccionX + DireccionsZ;
        Vector3 VectorVelocidad = Direccion * velocidad;
        rb.velocity = VectorVelocidad;
    }
}
