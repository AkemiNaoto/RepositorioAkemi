using UnityEngine;

public class Onze : MonoBehaviour
{
    
    public float VelocidadeInicial, Tempo, Aceleracao;

    void Start()
    {
        
        float VelocidadeFinal = VelocidadeInicial + Aceleracao * Tempo;
        Debug.Log("O canhão te jogou a " + VelocidadeInicial + "m/s e com uma acelaração de " + Aceleracao + "m/s² durante " + Tempo + " segundos, devido a isso você chegou a velocidade de " + VelocidadeFinal + "m/s");

    }

}
