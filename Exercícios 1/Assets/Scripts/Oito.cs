using UnityEngine;

public class Oito : MonoBehaviour
{
    
    public int Vida = 100;
    public int Dano;

    void Start()
    {
        
        Vida = Vida - Dano;
        if (Vida == 100)
        {
            
            Debug.Log("Sua vida continua cheia, coloque algum valor de dano na varíavel Dano e dê play novamente");

        }

        else
        {
            
            Debug.Log("O player foi atingido por um ataque e sofreu " + Dano + " de dano e agora está com " + Vida + " de vida");

        }

    }

}
