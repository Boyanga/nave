using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Meteoro_Roto : MonoBehaviour
{
    public bool MeteoroGrande;

    public GameObject MeteoroChicoPrefab;
    public GameObject GO;
    public Text TextoScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Bala" || other.gameObject.tag == "Player")
        {
            if (MeteoroGrande)
            {
                Instantiate(MeteoroChicoPrefab, transform.position + Random.onUnitSphere * 0.3f, Quaternion.identity);
                Instantiate(MeteoroChicoPrefab, transform.position + Random.onUnitSphere * 0.3f, Quaternion.identity);
                GO.GetComponent<MCanvas>().SetScore(10);
                Destroy(gameObject);
            }
            else {
                GO.GetComponent<MCanvas>().SetScore(5);
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {
       Destroy(gameObject, 5);
        GO = GameObject.Find("MCanvas");
    }
}
