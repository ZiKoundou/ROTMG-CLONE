using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraRotator : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform worldRoot;
    private Transform pivot;

    public float rotationSpeed = 90f;
    private float rotationInput = 0;
    void Start()
    {
        worldRoot = GameObject.FindWithTag("World Root").transform;
        pivot = GameObject.FindWithTag("Pivot").transform;
    }

    public void OnRotateWorld(InputAction.CallbackContext context)
    {
        rotationInput = context.ReadValue<float>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rotationInput != 0)
        {
            worldRoot.RotateAround(pivot.position, new Vector3(0,1,0), rotationSpeed * rotationInput * Time.deltaTime);
        }
    }
}
