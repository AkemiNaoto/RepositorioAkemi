using UnityEngine;

public class Dez : MonoBehaviour
{
   
    private float Salario = 1000f;

    void Start()
    {
        
        Salario = Salario + Salario * 0.10f;
        Debug.Log("O seu salário era R$1000, felizmente você recebeu um aumento de 10% e agora seu salário é R$" + Salario);

    }

}
