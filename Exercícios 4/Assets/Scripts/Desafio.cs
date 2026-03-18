using TMPro;
using UnityEngine;

public class Desafio : MonoBehaviour
{
    
    private int Jogador1, Jogador2, Pontos1, Pontos2;
    private bool Win1, Win2;

    void Start()
    {
        
        Win1 = false;
        Win2 = false;

    }
    
    void Update()
    {

        if(Input.anyKeyDown){
        if (Win1 != true || Win2 != true)
            {
            
                Jogador1 = Random.Range(1, 7);
                Jogador2 = Random.Range(1, 7);
                if(Jogador1 > Jogador2)
                {
                    
                    Pontos1++;
                    if(Pontos1 == 3)
                {
                    
                    Win1 = true;

                }
                }

                else if(Jogador1 == Jogador2)
                {
                    
                    return;

                }

                else if (Jogador1 < Jogador2)
                {
                    
                    Pontos2++;
                    if(Pontos2 == 3)
                {
                    
                    Win2 = true;

                }

                }
                
            }
        else if(Win1 == true)
            {
                
                print("Jogador 1 ganhou");

            }

        else if(Win2 == true)
            {
                
                print("Jogador 2 ganhou");

            }
        }
    }
}
