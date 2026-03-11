using UnityEngine;

public class Tres : MonoBehaviour
{
    
    private int Pontos, Multiplicador;

    void Start()
    {

        Pontos = 10; Multiplicador = 3;
        int PontosFinal = Pontos * Multiplicador;
        Debug.Log("Você tem 10 pontos, porém ao pegar o item seus pontos triplicaram resultando em " + PontosFinal + " pontos");

    }

}
