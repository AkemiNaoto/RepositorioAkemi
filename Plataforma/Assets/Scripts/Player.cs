using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    public float Velocidade = 5.0f;
    public float Impulso = 800.0f;
    public float Gravidade = 2.0f;
    public Transform SensorChao;
    public float SensorSize;
   [SerializeField] private bool EstaNoChao, Pular;
    private Rigidbody2D Rig;
    private SpriteRenderer Sr;
    private Animator Anima;
    

    public void Start()
    {

        Rig = GetComponent<Rigidbody2D>();
        Sr = GetComponent<SpriteRenderer>();   
        Anima = GetComponent<Animator>();

        Rig.gravityScale = Gravidade;

    }

    public void Update()
    {
        
        float AndarX = Input.GetAxisRaw("Horizontal") * Velocidade * Time.deltaTime;
        transform.Translate (AndarX, 0.0f, 0.0f);

            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                
                Sr.flipX = false;

            }

            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                
                Sr.flipX = true;

            }

            if (Input.GetButtonDown("Jump"))
            {
                
                Pular = true;
                Anima.SetBool("Jump", true);

            }

        EstaNoChao = Physics2D.OverlapCircle(SensorChao.position, SensorSize, 1 << LayerMask.NameToLayer("Chao"));
        Anima.SetFloat("Run", Math.Abs(Input.GetAxisRaw("Horizontal")));

    }

    public void FixedUpdate()
    {
        if (Pular && EstaNoChao)
        {
            
            Rig.AddForce(Vector2.up * Impulso, ForceMode2D.Impulse);
            Pular = false;
            
            Anima.SetBool("Jump", false);

        }
    }

   void OnDrawGizmos()
    {
        
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(SensorChao.position, SensorSize);

    }

}
