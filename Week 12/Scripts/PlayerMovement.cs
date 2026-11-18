using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;

    public Sprite steve_back;
    public Sprite steve_front;
    public Sprite steve_left;
    public Sprite steve_right;

    public Transform firePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
            spriteRenderer.sprite = steve_left;

            firePoint.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
            spriteRenderer.sprite = steve_right;
            firePoint.rotation = Quaternion.Euler(0, 0, -90);
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
            spriteRenderer.sprite = steve_back;
            firePoint.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
            spriteRenderer.sprite = steve_front;
            firePoint.rotation = Quaternion.Euler(0, 0, -180);
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
