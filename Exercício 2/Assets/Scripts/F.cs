using UnityEngine;

public class F : MonoBehaviour
{

    private int Distancia, Tempo;

    void Start()
    {

        Distancia = 120;
        Tempo = 10;
        int VelocidadeMedia = Distancia / Tempo;
        print("Akemi correu " + Distancia + " metros em " + Tempo + " segundos, assim alcançando uma velocidade média de " + VelocidadeMedia + " m/s²");
        
    }

    
}
