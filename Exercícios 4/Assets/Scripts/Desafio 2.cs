using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    
    [SerializeField] private int Numero, Dificuldade;
    private int Tentativas, Secreto, Dica, Dica2;
    [SerializeField]private bool Infinito;

    void Start()
    {
        
        Tentativas = 0;
        Dica = Random.Range(1, 21);
        Dica2 = Random.Range(1, 21);

        if (Dificuldade == 1)
        {

            Secreto = Random.Range(1, 51);

        }

        else if(Dificuldade == 2)
        {

            Secreto = Random.Range(1, 101);

        }

        else if(Dificuldade == 3)
        {

            Secreto = Random.Range(1, 501);

        }

        if(Infinito == false)
        {

            Tentativas = 3;
            print("O número está entre " + (Secreto - Dica) + " e " + (Secreto + Dica2) + ".");

        }

    }

    void Update()
    {
      
        if(Input.anyKeyDown)
        {

            if(Infinito == true)
            {

                Tentativas++;
                if(Numero == Secreto)
                {

                    print("Na sua " + Tentativas + "º você acertou o número secreto");

                }

                else if(Numero > Secreto)
                {

                    print("O número secreto é menor");

                }

                else if(Numero < Secreto)
                {

                    print("O número secreto é maior");

                }

            }

            else
            {

                if(Tentativas > 0)
                {

                Tentativas--;
                if(Numero == Secreto)
                {

                    print("Você acertou o número secreto restando " + Tentativas + " tentativas");

                }

                else if(Numero > Secreto)
                {

                    print("O número secreto é menor");

                }

                else if(Numero < Secreto)
                {

                    print("O número secreto é maior");

                }

                }

                else if(Tentativas <= 0)
                {

                    print("Game Over");

                }
            
            }

        }

    }
            
}