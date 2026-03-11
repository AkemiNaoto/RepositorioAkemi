using UnityEngine;

public class Cinco : MonoBehaviour
{
    
    private int ValorInicial, Divisor;

    void Start()
    {

        ValorInicial = 17;
        Divisor = 4;
        int Resto = ValorInicial % Divisor;
        Debug.Log("O que sobrou da divisão de 17 por 4 é " + Resto);



    }

}
