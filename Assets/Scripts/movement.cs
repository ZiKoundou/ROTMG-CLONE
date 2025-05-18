using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{

    [SerializeField] float speed = 5f;

    private Vector2 move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();

    }
    void movePlayer() {
        Vector3 movement = new Vector3(move.x, 0, move.y);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}   

