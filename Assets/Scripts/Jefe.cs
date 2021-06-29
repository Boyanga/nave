using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jefe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0f,30f,0f) * Time.deltaTime);
    }
   
}
