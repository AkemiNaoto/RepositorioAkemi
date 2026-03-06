using UnityEngine;

public class Doze : MonoBehaviour
{
    public int Pontos, InimigosDerrotados, Bonus;
    void Start()
    {
        
        int PontuacaoFinal = Pontos * InimigosDerrotados + Bonus;
        Debug.Log("Você derrotou " + InimigosDerrotados + " inimigos, e conquistou um bônus de " + Bonus + " pontos, devido a isso você ficou com " + PontuacaoFinal + " pontos");

    }

}
