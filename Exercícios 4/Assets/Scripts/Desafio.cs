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
        Pontos1 = 0; 
        Pontos2 = 0; 
    }
    
    void Update()
    {

        if (Input.anyKeyDown)
        {

            if (!Win1 && !Win2) 
            {

                Jogador1 = Random.Range(1, 7);
                Jogador2 = Random.Range(1, 7);
                Debug.Log($"Jogador 1: {Jogador1}, Jogador 2: {Jogador2}"); 

                if (Jogador1 > Jogador2)
                {

                    Pontos1++;
                    Debug.Log("Jogador 1 marcou ponto.");

                    if (Pontos1 == 3)
                    {

                        Win1 = true;

                    }

                }
                else if (Jogador1 < Jogador2)
                {

                    Pontos2++;
                    Debug.Log("Jogador 2 marcou ponto.");

                    if (Pontos2 == 3)
                    {

                        Win2 = true;

                    }

                }
                else 
                {

                    Debug.Log("Empatou, ninguém marcou ponto.");

                }

                print("------------------------------");

            }

            else if (Win1)
            {

                Debug.Log("Jogador 1 ganhou");

            }

            else if (Win2)
            {

                Debug.Log("Jogador 2 ganhou");
                
            }
        }
    }
}

