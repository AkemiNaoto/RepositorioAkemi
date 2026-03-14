using UnityEngine;

public class E : MonoBehaviour
{

    private int Bronze, Prata, Ouro;

    void Start()
    {
        
        int Quantidade1 = 12;
        int Quantidade2 = 8;
        int Quantidade3 = 3;
        Bronze = 1;
        Prata = 5;
        Ouro = 10;
        int Soma = Quantidade1 * Bronze + Quantidade2 * Prata + Quantidade3 * Ouro;
        print("Akemi coletou " + Quantidade1 + " moedas de bronze, " + Quantidade2 + " moedas de prata e " + Quantidade3 + " moedas de ouro, ao somar o valor de todas ele ficou com " + Soma + " de dinheiro");

    }

}
