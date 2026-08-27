using UnityEngine;

public class AlgumaCoisa2 : MonoBehaviour
{
    
    [SerializeField] private string NomePersonagem;
    void Start()
    {
        
        MostrarPesonagem(NomePersonagem);

    }

    void MostrarPesonagem(string nome)
    {
        nome = nome.ToUpper();
        print("Personagem criado: " + nome);

    }
}
