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
        print("O valor de A � " + A + " e o valor de B � " + B + ", a soma dos dois d� " + Soma);

    }

    public void Dois()
    {

        Vida = 100;
        Dano = 25;
        int VidaFinal = Vida - Dano;
        print("O player tem 100 de vida, por�m ao sofrer um ataque perdeu 25 de vida resultando em " + VidaFinal + " de vida");

    }

    public void Tres()
    {

        Pontos = 10; Multiplicador = 3;
        int PontosFinal = Pontos * Multiplicador;
        print("Voc� tem 10 pontos, por�m ao pegar o item seus pontos triplicaram resultando em " + PontosFinal + " pontos");

    }

    public void Quatro()
    {

        Moedas = 50;
        Divisor = 5;
        int MoedasFinal = Moedas / Divisor;
        print("Voc� derrotou um monstro e ele deu 50 moedas, por�m voc� decidiu dividir com seus 4 amigos e cada um de voc�s ficou com " + Moedas + " moedas");

    }

    public void Cinco()
    {

        ValorInicial = 17;
        Divisor = 4;
        int Resto = ValorInicial % Divisor;
        print("O que sobrou da divis�o de 17 por 4 � " + Resto);



    }

    public void Seis()
    {

        print("A idade � " + Idade + " anos");

    }

    public void Sete()
    {

        A = 657; B = 450;
        int Soma = A + B;
        print("O valor de A � " + A + " e o valor de B � " + B + " e ao somar os dois o valor � " + Soma);

    }

    public void Oito()
    {

        Vida = 100;
        Vida = Vida - Dano;
        if (Vida == 100)
        {

            print("Sua vida continua cheia, coloque algum valor de dano na var�avel Dano e d� play novamente");

        }

        else
        {

            print("O player foi atingido por um ataque e sofreu " + Dano + " de dano e agora est� com " + Vida + " de vida");

        }

    }

    public void Nove()
    {

        if (Numero == 0)
        {

            print("Qualquer opera��o de multiplica��o ou divis�o com 0 o resultado sempre ser� 0");

        }

        else
        {

            print("Voc� escolheu o n�mero " + Numero);
            Numero = Numero * 2;
            print("O dobro dele � " + Numero);
            Numero = Numero / 4;
            print("E a metade dele � " + Numero);

        }

    }

    public void Dez()
    {

        Salario = Salario + Salario * 0.10f;
        print("O seu sal�rio era R$1000, felizmente voc� recebeu um aumento de 10% e agora seu sal�rio � R$" + Salario);

    }

    public void Onze()
    {

        float VelocidadeFinal = VelocidadeInicial + Aceleracao * Tempo;
        print("O canh�o te jogou a " + VelocidadeInicial + "m/s e com uma acelara��o de " + Aceleracao + "m/s� durante " + Tempo + " segundos, devido a isso voc� chegou a velocidade de " + VelocidadeFinal + "m/s");

    }

    public void Doze()
    {

        int PontuacaoFinal = Pontos * InimigosDerrotados + Bonus;
        print("Voc� derrotou " + InimigosDerrotados + " inimigos, e conquistou um b�nus de " + Bonus + " pontos, devido a isso voc� ficou com " + PontuacaoFinal + " pontos");

    }

}