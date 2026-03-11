using UnityEngine;
using UnityEngine.UI;

public class Controle : MonoBehaviour
{
    private int Soma;
    private int Multiplicador;
    private int Moedas, Divisor;
    private int ValorInicial;
    [SerializeField] private int Idade;
    [SerializeField] private int A, B;
    [SerializeField] private int Vida;
    [SerializeField] private int Dano;
    [SerializeField] private int Numero;
    private float Salario = 1000f;
    [SerializeField] private float VelocidadeInicial, Tempo, Aceleracao;
    [SerializeField] private int Pontos, InimigosDerrotados, Bonus;

    public void Um()
    {

        A = 7;
        B = 876;
        Soma = A + B;
        print("O valor de A é " + A + " e o valor de B é " + B + ", a soma dos dois dá " + Soma);

    }

    public void Dois()
    {

        Vida = 100;
        Dano = 25;
        int VidaFinal = Vida - Dano;
        print("O player tem 100 de vida, porém ao sofrer um ataque perdeu 25 de vida resultando em " + VidaFinal + " de vida");

    }

    public void Tres()
    {

        Pontos = 10; Multiplicador = 3;
        int PontosFinal = Pontos * Multiplicador;
        print("Você tem 10 pontos, porém ao pegar o item seus pontos triplicaram resultando em " + PontosFinal + " pontos");

    }

    public void Quatro()
    {

        Moedas = 50;
        Divisor = 5;
        int MoedasFinal = Moedas / Divisor;
        print("Você derrotou um monstro e ele deu 50 moedas, porém você decidiu dividir com seus 4 amigos e cada um de vocês ficou com " + Moedas + " moedas");

    }

    public void Cinco()
    {

        ValorInicial = 17;
        Divisor = 4;
        int Resto = ValorInicial % Divisor;
        print("O que sobrou da divisão de 17 por 4 é " + Resto);



    }

    public void Seis()
    {

        print("A idade é " + Idade + " anos");

    }

    public void Sete()
    {

        A = 657; B = 450;
        int Soma = A + B;
        print("O valor de A é " + A + " e o valor de B é " + B + " e ao somar os dois o valor é " + Soma);

    }

    public void Oito()
    {

        Vida = 100;
        Vida = Vida - Dano;
        if (Vida == 100)
        {

            print("Sua vida continua cheia, coloque algum valor de dano na varíavel Dano e dê play novamente");

        }

        else
        {

            print("O player foi atingido por um ataque e sofreu " + Dano + " de dano e agora está com " + Vida + " de vida");

        }

    }

    public void Nove()
    {

        if (Numero == 0)
        {

            print("Qualquer operação de multiplicação ou divisão com 0 o resultado sempre será 0");

        }

        else
        {

            print("Você escolheu o número " + Numero);
            Numero = Numero * 2;
            print("O dobro dele é " + Numero);
            Numero = Numero / 4;
            print("E a metade dele é " + Numero);

        }

    }

    public void Dez()
    {

        Salario = Salario + Salario * 0.10f;
        print("O seu salário era R$1000, felizmente você recebeu um aumento de 10% e agora seu salário é R$" + Salario);

    }

    public void Onze()
    {

        float VelocidadeFinal = VelocidadeInicial + Aceleracao * Tempo;
        print("O canhão te jogou a " + VelocidadeInicial + "m/s e com uma acelaração de " + Aceleracao + "m/s² durante " + Tempo + " segundos, devido a isso você chegou a velocidade de " + VelocidadeFinal + "m/s");

    }

    public void Doze()
    {

        int PontuacaoFinal = Pontos * InimigosDerrotados + Bonus;
        print("Você derrotou " + InimigosDerrotados + " inimigos, e conquistou um bônus de " + Bonus + " pontos, devido a isso você ficou com " + PontuacaoFinal + " pontos");

    }

}
