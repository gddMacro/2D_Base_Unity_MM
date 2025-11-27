using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speedDelta;
    [SerializeField] private float jumpForceDelta;
    
    private Rigidbody2D physics2D;

    private void Awake()
    {
        this.physics2D = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        this.physics2D.linearVelocityX = Input.GetAxis("Horizontal") * this.speedDelta;

        if (Input.GetButtonDown("Jump"))
            this.physics2D.linearVelocityY = this.jumpForceDelta;
    }
}