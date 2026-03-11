using UnityEngine;

public class Dois : MonoBehaviour
{
    
     private int Vida, Dano;
    void Start()
    {
        
        Vida = 100; 
        Dano = 25;
        int VidaFinal = Vida - Dano;
        Debug.Log("O player tem 100 de vida, porém ao sofrer um ataque perdeu 25 de vida resultando em " + VidaFinal + " de vida");

    }

}
