using UnityEngine;

public class G : MonoBehaviour
{
    
    private int Vida, Inimigo1, Inimigo2, Inimigo3;
    void Start()
    {

        Vida = 100;
        Inimigo1 = 20;
        Inimigo2 = 35;
        Inimigo3 = 15;
        int Soma = Vida - Inimigo1 - Inimigo2 - Inimigo3;
        print("Akemi tinha " + Vida + " de vida, porém tomou dano de 3 inimigos e ficou com a vida restante de " + Soma + " de vida");

    }

}
