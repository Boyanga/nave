using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_jefe : MonoBehaviour
{
    private float Velocidad = 2;
    private float tiempo;
    private int tDisparo;
    public Transform Spawn_bala;
    public GameObject Disparo_M_Prefab;
    public GameObject Disparo_M_Prefab2;
    public float Rate = 1.5f;
    private Vector3 velocidadTotal;

    void Update()
    {
        if (transform.position.x < -5.03)
        {
            velocidadTotal = transform.forward * -Velocidad;
        }
        else if (transform.position.x > 4.51)
        {
            velocidadTotal = transform.forward * Velocidad;
        }
        transform.position += velocidadTotal * Time.deltaTime;

        tiempo += Time.deltaTime;

        if (tiempo > Rate)
        {
            Instantiate(Disparo_M_Prefab, Spawn_bala.position, Disparo_M_Prefab.transform.rotation);
            tiempo = 0;
            tDisparo = tDisparo +1;
        }

        if (tDisparo > 1)
        {
            Instantiate(Disparo_M_Prefab2, Spawn_bala.position, Disparo_M_Prefab2.transform.rotation);
            tDisparo = 0;
        }
    }
}
