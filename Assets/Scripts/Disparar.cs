using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform LanzadorR;
    public Transform LanzadorL;

    public GameObject DisparoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
           Instantiate(DisparoPrefab, LanzadorL.position,DisparoPrefab.transform.rotation);
            Instantiate(DisparoPrefab, LanzadorR.position, DisparoPrefab.transform.rotation);
        }
    }
}
