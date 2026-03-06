using UnityEngine;

public class um : MonoBehaviour
{
    
    int A, B, Soma;

    void Start()
    {
        
        A = 7; B = 876;
        Soma = A + B;
        Debug.Log("O valor de A é " + A + " e o valor de B é " + B + ", a soma dos dois dá " + Soma);

    }

}
