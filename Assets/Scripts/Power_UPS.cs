using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_UPS : MonoBehaviour
{
    public float tiempo = 0;
    public float tiempo2 = 0;
    public Transform P1;
    public GameObject DisparoPrefab;
    public Transform D2;
    public Transform D3;
    public bool t = false;
    public bool t2 = false;



    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            t = true;
        }
        if (t)
        {
            tiempo += Time.deltaTime;
        }
        if (tiempo >= 5 && Input.GetButtonDown("Jump"))
        {
            Instantiate(DisparoPrefab, P1.position, DisparoPrefab.transform.rotation);
            tiempo = 0;
            t = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            t2 = true;
        }
        if (t2)
        {
            tiempo2 += Time.deltaTime;
        }
        if (tiempo2 >= 5 && Input.GetButtonDown("Jump"))
        {
            Quaternion rot = Quaternion.Euler(90, -25, 0);
            Instantiate(DisparoPrefab, D2.position, rot);
            Quaternion rot2 = Quaternion.Euler(90, 25, 0);
            Instantiate(DisparoPrefab, D3.position, rot2);
            tiempo2 = 0;
            t2 = false;
        }

    }
}
