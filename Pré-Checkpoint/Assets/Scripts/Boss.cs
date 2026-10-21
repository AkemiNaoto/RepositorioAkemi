using System.Collections;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Boss : MonoBehaviour
{
    float Velocidade = 5.0f;
    public Estado EstadoAtual;
    bool EncostouParede = false;
    SpriteRenderer Sr;

    public enum Estado
    {

        Parado,
        Movendo,
        Desvirando

    }

    void Start()
    {

        Sr = GetComponent<SpriteRenderer>();
        StartCoroutine(MudarEstado());

    }


    void Update()
    {

        if (EstadoAtual == Estado.Parado)
        {

            if (transform.position.x < 0)
            {
                
                Sr.flipX = true;

            }

            if (transform.position.x > 0)
            {
                
                Sr.flipX = false;

            }
            //StartCoroutine(Atirando());

        }

        else if (EstadoAtual == Estado.Desvirando)
        {

            // Colocar pra rodar animação

        }

        else if (EstadoAtual == Estado.Movendo)
        {

            transform.Translate(Vector2.left * Velocidade * Time.deltaTime);

        }

    }

    void OnCollisionEnter2D(Collision2D Col)
    {

        if (Col.gameObject.tag == "Parede")
        {

            EncostouParede = true;

        }

    }

    IEnumerator MudarEstado()
    {

        EstadoAtual = Estado.Parado;
        yield return new WaitForSeconds(10.0f);

        EstadoAtual = Estado.Desvirando;
        yield return new WaitForSeconds(3.0f);

        EstadoAtual = Estado.Movendo;
        yield return new WaitForSeconds(3.5f);

        EstadoAtual = Estado.Desvirando;
        yield return new WaitForSeconds(3.0f);
        StartCoroutine(MudarEstado());



    }

    /*IEnumerator Atirando()
    {
        
        

    }*/
}
