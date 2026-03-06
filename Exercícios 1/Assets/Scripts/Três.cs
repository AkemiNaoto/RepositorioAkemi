using UnityEngine;

public class Três : MonoBehaviour
{
    
    int Pontos, Multiplicador;

    void Start()
    {

        Pontos = 10; Multiplicador = 3;
        Pontos = Pontos * Multiplicador;
        Debug.Log("Você tem 10 pontos, porém ao pegar o item seus pontos triplicaram resultando em " + Pontos + " pontos");

    }

}
