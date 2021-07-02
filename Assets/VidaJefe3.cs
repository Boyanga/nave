using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJefe3 : MonoBehaviour
{
    public int vida = 100;
    public movementJefe3 jefe3;
    void OnTriggerEnter(Collider col)
    {
     if (col.gameObject.tag == "Bala")
     {
        vida = vida - 1;
        if (vida == 95){
            jefe3.ChangeState();
        }
        if (vida == 0)
        {
            Destroy(gameObject);
                SceneManager.LoadScene("Inicio");
            }
     }
    }
}
