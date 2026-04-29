using UnityEngine;

public class AlgumaCoisa3 : MonoBehaviour
{
    
    [SerializeField] private int Ataque, Defesa;
    private int C;


    void Start()
    {
        
        CalcularDanoAtaque(Ataque, Defesa);

    }

    void CalcularDanoAtaque(int A, int D)
    {
        
        int B = A - D;

        if(B <= 0)
        {
            
            print("O dano é 0");
            
        }

        else
        {

            print("O dano é " + B);
            
        }

    }
}
