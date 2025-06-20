using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    private float animationSpeed;
    private Vector2 move;
    private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();

    }
    void movePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0, move.y);
        if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        bool isIdle = movement.x == 0 && movement.z == 0;
        if (isIdle)
        {
            animator.SetBool("isMoving", false);
        }
        else
        {
            animationSpeed = speed * 0.35f;
            animator.SetFloat("moveSpeed", animationSpeed);
            animator.SetFloat("horizontalMovement", movement.x);
            animator.SetFloat("verticalMovement", movement.z);
            animator.SetBool("isMoving", true);
        }
        
    }

    
}   

