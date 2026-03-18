using UnityEngine;

public class C : MonoBehaviour
{
    
    [SerializeField] private int A;
    
    void Update()
    {
        
        if(A % 2 != 0)
        {
            
            print("O número é impar");

        }

        else
        {
            
            print("O número é par");

        }

    }
}
