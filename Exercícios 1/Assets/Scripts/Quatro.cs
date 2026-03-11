using UnityEngine;

public class Quatro : MonoBehaviour
{
    
    private int Moedas, Divisor;

    void Start()
    {
        
        Moedas = 50;
        Divisor = 5;
        int MoedasFinal = Moedas / Divisor;
        Debug.Log("Você derrotou um monstro e ele deu 50 moedas, porém você decidiu dividir com seus 4 amigos e cada um de vocês ficou com " + Moedas + " moedas");

    }

}
