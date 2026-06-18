using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 direction;
    public float speed;
    public float lifeTime = 1f;
    float counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        counter = 0;
    }

    public void Fire()
    {
        rb.linearVelocity = direction * speed;
    }

    //function to direct the force in a certain direction

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter > lifeTime) {
            Destroy(gameObject);
        }
    }
}
