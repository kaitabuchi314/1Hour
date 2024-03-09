using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5;

    public float jumpForce = 3;

    public Rigidbody2D rb;

    public float maxDist = 1.5f;
    public GroundCheck checker;
    void Update()  {
        float inputX = Input.GetAxis("Horizontal");
        rb.velocity += new Vector2(inputX * moveSpeed * Time.deltaTime, 0);
        

        if (Input.GetButtonDown("Jump") && checker.grounded) {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
