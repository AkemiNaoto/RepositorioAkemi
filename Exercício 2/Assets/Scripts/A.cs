using UnityEngine;

public class A : MonoBehaviour
{
    
    private int XP1, XP2, XP3;
    private int InimigoPequeno, InimigoMedio, Chefe;
    

    void Start()
    {
        
        XP1 = 10;
        XP2 = 25;
        XP3 = 100;
        InimigoPequeno = 3;
        InimigoMedio = 2;
        Chefe = 1;
        int Player = InimigoPequeno * XP1 + InimigoMedio * XP2 + Chefe * XP3;
        print("Ao fim da batalha, depois de derrotar todos os monstros e o boss, Akemi acumulou " + Player + " pontos de XP");


    }
}
