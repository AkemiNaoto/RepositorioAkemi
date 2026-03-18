using UnityEngine;

public class D : MonoBehaviour
{
   
    [SerializeField] private int A, B;
    
    void Update()
    {
        
        if(A != B)
        {
            
            print("O valor de A é diferente de B");

        }

        else
        {
            
            print("O valor de A é igual a B");

        }

    }
}
