using UnityEngine;

public class Função : MonoBehaviour
{
    
    [SerializeField] private string Nome;
    void Start()
    {
        
        Saudacao(Nome);

    }

    void Saudacao(string n)
    {
        
        print("Vai me negar um prato de comida " + n );

    }
    
}
