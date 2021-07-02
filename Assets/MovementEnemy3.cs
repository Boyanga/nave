using UnityEngine;

public class MovementEnemy3 : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float zigzagueante =3;
    [Range(0.0f, 10.0f)]
    public float velocityForward =2;
    [Range(-10.0f, 10.0f)]
    public float velocityRight =5;
    private float xPos;


    void Start(){
        xPos= transform.position.x ;
    }

    void Update()
    {
        //movimiento para adelante
        transform.position += transform.forward * -velocityForward * Time.deltaTime;
        //moviemiendo zigzagueante
        transform.position += transform.right * -velocityRight * Time.deltaTime;


        if(transform.position.x > xPos + zigzagueante || transform.position.x < xPos - zigzagueante){
            velocityRight*=-1;
        }
    }

}
