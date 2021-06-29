using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_1 : MonoBehaviour
{
    public GameObject GO;
    public float Velocidad = 5;
    public GameObject jugador;
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
        transform.LookAt(jugador.transform,Vector3.up);
        
    }
    void Start()
    {
        GO = GameObject.Find("MCanvas");
        jugador = GameObject.Find("Player");
       
    }
}
