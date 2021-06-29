using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_2 : MonoBehaviour
{
    public GameObject GO;
    private float Velocidad = 2;
    public Transform Spawn_bala;
    public GameObject Disparo_M_Prefab;
    public float Rate = 1.5f;
    private float tiempo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bala" || other.gameObject.tag == "Player")
        {
            GO.GetComponent<MCanvas>().SetScore(20);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.position += transform.forward * Velocidad * Time.deltaTime;
        tiempo += Time.deltaTime;
       
        if (tiempo > Rate)
        {
            Instantiate(Disparo_M_Prefab, Spawn_bala.position, Disparo_M_Prefab.transform.rotation);
            tiempo = 0;
        }
    }
    void Start()
    {
        GO = GameObject.Find("MCanvas");
        Destroy(gameObject, 9);
    }
}
