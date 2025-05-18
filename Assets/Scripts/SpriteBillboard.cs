using UnityEngine;

public class SpriteBillBoard : MonoBehaviour
{
    [SerializeField] bool freezeXZ;

    // Update is called once per frame
    private void Update()
    {
        if (freezeXZ == true)
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
