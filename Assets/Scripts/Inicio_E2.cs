using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio_E2 : MonoBehaviour
{
    public float InstanceRate = 5;
    public GameObject Enemigo_2Prefab;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > InstanceRate)
        {
            Quaternion rot = Quaternion.Euler(0, 180, 0);
            Instantiate(Enemigo_2Prefab, transform.position, rot);
            timer = 0;
        }
    }
}
