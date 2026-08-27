using Unity.VisualScripting;
using UnityEngine;

public class a : MonoBehaviour
{
  
    Vector2 PosicaoInicial = new Vector2(0.0f, -3.0f);
    Vector2 Movimento;
    float Velocidade = 10;

    void Start()
    {
        
        transform.position = PosicaoInicial;
        Velocidade = Velocidade * Time.deltaTime;

    }

    void Update()
    {

        if(Input.GetButton("Fire1"))
        {
            
            transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);

        }

        else if(Input.GetButtonUp("Fire1"))
        {
            
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        }

        float MovimentoX = Input.GetAxis("Horizontal") * Velocidade;
        float MovimentoY = Input.GetAxis("Vertical") * Velocidade;
        transform.Translate(MovimentoX, MovimentoY, 0.0f);

        if(transform.position.x > 8.47f || transform.position.x < -8.47f)
        {
            
            transform.position = new Vector2(0.0f, 0.0f);

        }

        else if(transform.position.y > 4.34 || transform.position.y < -4.7f)
        {
            
            transform.position = new Vector2(0.0f, 0.0f);

        }

    }



}
