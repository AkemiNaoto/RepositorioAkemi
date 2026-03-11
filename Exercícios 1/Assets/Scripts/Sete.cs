using UnityEngine;

public class Sete : MonoBehaviour
{
    [SerializeField] private int A, B;
    void Start()
    {
        
        A = 657; B = 450;
        int Soma = A + B;
        Debug.Log("O valor de A é " + A + " e o valor de B é " + B + " e ao somar os dois o valor é " + Soma);

    }

}
