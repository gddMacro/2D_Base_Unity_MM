using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        this.transform.position += Vector3.right * (Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}