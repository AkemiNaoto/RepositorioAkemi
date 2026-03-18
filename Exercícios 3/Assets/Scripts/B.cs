using UnityEngine;

public class B : MonoBehaviour
{

    [SerializeField] private int Idade;
    void Update()
    {

        if(Idade > 18)
        {
            
            print("A pessoa é maior de 18 anos.");

        }

        else if(Idade == 18)
        {
            
            print("A pessoa tem 18 anos.");

        }
        else
        {
            
            print("A pessoa é menor de 18 anos.");

        }
        
    }
}
