using UnityEngine;

public class movementEnemy4 : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float velocityForward =2;
    [Range(0.0f, 10.0f)]
    public float rotationVelocity =2;    
    public Transform Spawn_bala;
    public GameObject Disparo_M_Prefab;
    public float Rate = 1.5f;
    private float tiempo;
    void Update()
    {
        transform.position += new Vector3(0,0,1) * -velocityForward * Time.deltaTime;
        transform.Rotate(0,rotationVelocity,0);

        tiempo += Time.deltaTime;
        if (tiempo > Rate)
        {
            Instantiate(Disparo_M_Prefab, Spawn_bala.position, Disparo_M_Prefab.transform.rotation);
            tiempo = 0;
        }
    }
}
