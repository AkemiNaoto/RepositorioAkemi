using UnityEngine;

public class C : MonoBehaviour
{

    private int Mana, Fogo, Eletrico, Escudo;
    void Start()
    {

        Mana = 100;
        Fogo = 30;
        Eletrico = 20;
        Escudo = 25;
        print("Akemi tinha " + Mana + " de mana, ela castou o feitiço Bola de Fogo que custa " + Fogo + " de mana, e ficou com " + (Mana - Fogo) + " de mana restante, logo após castou o feitiço Raio Elétrico que custa " + Eletrico + " de mana, sobrando apenas " + (Mana - Fogo - Eletrico) + " de mana, e então por fim castou o feitiço Escudo Mágico que custa " + Escudo + " de mana, e por fim sobrou " + (Mana - Fogo - Eletrico - Escudo) + " de mana.");
        
    }

}
