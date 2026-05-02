using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class Weapon : MonoBehaviour
{
	public GameObject bullet;
	public float bulletSpeed;
    private Vector2 mouseScreenPos;
    public void OnFire(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			Fire();
		}
	}

	public void OnLook(InputAction.CallbackContext context)
	{
		mouseScreenPos = context.ReadValue<Vector2>();
    }
	public void Fire()
	{
		var firedBullet =  Instantiate(bullet, transform.position, Quaternion.identity);
		firedBullet.GetComponent<Bullet>().direction = GetDirFromMouse();
		firedBullet.GetComponent<Bullet>().Fire();
    }
    // Use this for initialization
    void Start()
	{
		
	}
	//get mouse position from screen cast ray down till it hits plane
	// get dir from plane point and character
	// set dir of bullet to that 

	Vector3 GetDirFromMouse()
	{
		Ray ray = Camera.main.ScreenPointToRay(mouseScreenPos);
		if (Physics.Raycast(ray, out var hitInfo, 1000f)) { 
			Vector3 hitPoint = hitInfo.point;
			Vector3 dir = (hitPoint - transform.position).normalized;
			return dir;
		}
		return Vector3.zero;
	}
	// Update is called once per frame
	void Update()
	{

	}
}
