using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 direction;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    public void Fire()
    {
        rb.linearVelocity = direction * speed;
    }

    //function to direct the force in a certain direction

    // Update is called once per frame
    void Update()
    {
        
    }
}
