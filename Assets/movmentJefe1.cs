using UnityEngine;

public class movmentJefe1 : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float velocityForward =2;
    public float until=0; 
    public float Rate = 1.5f;
    private float tiempo;
    public Transform Spawn_bala;
    public GameObject Disparo_M_Prefab;

    void Update()
    {
        if(transform.position.z > until){
            transform.position += transform.forward * -velocityForward * Time.deltaTime;
        }
        else{
            tiempo += Time.deltaTime;
            if (tiempo > Rate){
                Instantiate(Disparo_M_Prefab, Spawn_bala.position, Disparo_M_Prefab.transform.rotation);
                tiempo = 0;
            }
        }
    }
}
