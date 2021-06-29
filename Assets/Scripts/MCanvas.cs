using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MCanvas : MonoBehaviour
{
    public Text Vida;
    public Text Score;
    private int puntos = 0;
    private int corazones = 10;
    public void SetVida(int x)
    {
        corazones -= x;
        Vida.text = "Vida: "+ corazones.ToString();
    }
    public void SetScore(int x)
    {
        puntos += x;
        Score.text = "Score: "+puntos.ToString();
    }
    void Update()
    {
        if (corazones == 0)
        {
            SceneManager.LoadScene("Inicio");
        }
        if (puntos >= 1000) 
        {
            SceneManager.LoadScene("Jefe");
        }
    }


}
