using UnityEngine;

public class Quatro : MonoBehaviour
{
    
    int Moedas;

    void Start()
    {
        
        Moedas = 50 / 5;
        Debug.Log("Você derrotou um monstro e ele deu 50 moedas, porém você decidiu dividir com seus 4 amigos e cada um de vocês ficou com " + Moedas + " moedas");

    }

}
