using UnityEngine;

public class D : MonoBehaviour
{
    
    private int Missao1, Missao2, Missao3;

    void Start()
    {

        Missao1 = 12;
        Missao2 = 18;
        Missao3 = 9;
        int Soma = Missao1 + Missao2 + Missao3;
        print("Akemi começou uma missão, a primeira fase durou " + Missao1 + " minutos, a segunda fase durou " + Missao2 + " minutos e por fim a terceira fase durou " + Missao3 + " minutos, ao fim da missão foi calculado todas as partes e a missão durou ao todo " + Soma + " minutos");

    }

}
