using UnityEngine;

public class A : MonoBehaviour
{
    [SerializeField] private int a, b;
    void Update()
    {
        
        if (a > b)
        {
            
            print("A é maior que B.");

        }

        else if(a == b)
        {
            
            print("A é igual a B");

        }

        else
        {
            
            print("B é maior que A");

        }

    }
}
