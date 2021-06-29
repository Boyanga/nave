using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Enemiga : MonoBehaviour
{
  public float Velocidad = 20;
    public GameObject GO;

    void Start()
  {
      Destroy(gameObject, 3);
  }
  
  void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Bala" || col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
  }
  void Update()
  {
      transform.position -= transform.up * Velocidad * Time.deltaTime;
        Destroy(gameObject, 3);

    }
}
