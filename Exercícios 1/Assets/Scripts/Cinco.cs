using UnityEngine;

public class Cinco : MonoBehaviour
{
    
    int Resto;

    void Start()
    {
        
        Resto = 17 % 4;
        Debug.Log("O que sobrou da divisão de 17 por 4 é " + Resto);



    }

}
