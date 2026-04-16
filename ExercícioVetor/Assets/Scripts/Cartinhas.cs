using UnityEngine;

public class Cartinhas : MonoBehaviour
{
    
    private int[] Carta1 = new int[] {8, 5, 6};
    private int[] Carta2 = new int[] {4, 9, 7};
    private int[] Carta3 = new int[] {6, 6, 6};
    private int[] Carta4 = new int[] {7, 4, 8};
    private int[] Carta5 = new int[] {5, 7, 5};
    private int[] Cartas;
    private int Rodadas = 5;


    void Start()
    {

        for (int i = 0; i <= Rodadas; i++)
        {
            
            int Atributos = Random.Range(1, 4);
            int Player = Random.Range(1, 6);
            int Npc = Random.Range(1, 6);

        }

    }

    
    void Update()
    {
        
    }
}
