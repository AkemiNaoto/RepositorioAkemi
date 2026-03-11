using UnityEngine;

public class Desafio : MonoBehaviour
{
    [SerializeField] private string Funcionario;
    [SerializeField] private int Horas;
    [SerializeField] private float ValorHoras;

    void Start()
    {

        Funcionario = "Akemi";
        Horas = 12;
        ValorHoras = 5.4f;
        float ValorDoTurno = Horas * ValorHoras;
        print(Funcionario + " Trabalhou durante " + Horas + " horas, e ela ganha R$" +  ValorHoras + " por cada hora, então ao fim do seu turno ganhou R$" + ValorDoTurno);
        
    }

    
}
