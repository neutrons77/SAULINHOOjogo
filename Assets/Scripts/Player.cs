using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    public Transform arma;

    private bool amdando;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        
        
        amdando = false;
        
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Camera.main.nearClipPlane + 1f; 

        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        
        if ( mouseWorldPosition.x > transform.position.x)
        {
            spriteRenderer.flipX = false;
        }
        
       
        if ( mouseWorldPosition.x < transform.position.x)
        {
            spriteRenderer.flipX = true;
        }

        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(getVelocidade() * Time.deltaTime, 0, 0);  
            amdando = true;
        }

       
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(getVelocidade() * Time.deltaTime, 0, 0);
            amdando = true;
        }
        
      
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, getVelocidade() * Time.deltaTime, 0); 
            amdando = true;
        }
        
       
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, getVelocidade() * Time.deltaTime, 0);  
            amdando = true;
        }
        
        animator.SetBool("Andando", amdando);
    }
}
