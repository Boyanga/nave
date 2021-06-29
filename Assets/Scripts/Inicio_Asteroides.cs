using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio_Asteroides : MonoBehaviour
{
    public float InstanceRate = 5;
    public GameObject Meteoro1Prefab;
    public float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > InstanceRate)
        {
            Instantiate(Meteoro1Prefab, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
