using UnityEngine;

public class Sete : MonoBehaviour
{
    public int A, B, Soma;
    void Start()
    {
        
        A = 657; B = 450;
        Soma = A + B;
        Debug.Log("O valor de A é " + A + " e o valor de B é " + B + " e ao somar os dois o valor é " + Soma);

    }

}
