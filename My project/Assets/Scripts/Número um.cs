using UnityEngine;

public class Númeroum : MonoBehaviour
{
    
    private int Fios; 
    [SerializeField] private int Numero;
    void Start()
    {

        Fios = Random.Range(1, 4);
        Numero = 1;
        print("Uma bomba está armada escolha entre os 3 fios para cortar");

    }
    void Update()
    {
        
    if(Input.anyKeyDown)
        {

            if(Numero == Fios)
            {
                
                print("Você cortou o fio certo parabéns em desarmar a bomba");

            }

            else if(Numero > Fios)
            {
                


            }

        }

    }
}
