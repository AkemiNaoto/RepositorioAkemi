using UnityEngine;

public class B : MonoBehaviour
{
    private int Dano;
    private int DanoBonus;
    private int Arma;
    void Start()
    {
        
        Dano = 15;
        Arma = Dano + 5;
        DanoBonus = Arma * 2; 
        print("Akemi dá " + Dano + " de dano, porém ela coletou uma espada e ficou com " + Arma + " de dano, e também coletou um bônus ficando com " + DanoBonus + " de dano, porém é só temporário");

    }
}
