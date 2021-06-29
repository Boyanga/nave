using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio_E1 : MonoBehaviour
{
    public float InstanceRate = 5;
    public GameObject Enemigo_1Prefab;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > InstanceRate) 
        {
            Instantiate(Enemigo_1Prefab, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
