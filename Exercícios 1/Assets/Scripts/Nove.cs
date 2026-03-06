using UnityEngine;

public class Nove : MonoBehaviour
{
    public int Numero;
    void Start()
    {

        if (Numero == 0)
        {
            
            Debug.Log("Qualquer operação de multiplicação ou divisão com 0 o resultado sempre será 0");

        }

        else
        {
            
            Debug.Log("Você escolheu o número " + Numero);
            Numero = Numero * 2;
            Debug.Log("O dobro dele é " + Numero);
            Numero = Numero / 4;
            Debug.Log("E a metade dele é " + Numero);

        }
        
    }

}
