using UnityEngine;

public class FarmerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 10f;

    public Transform basket; // Gán thùng đựng trứng từ Inspector

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Lấy giá trị từ bàn phím
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        // Di chuyển thùng theo người nông dân
        if (basket != null)
        {
            basket.position = new Vector2(transform.position.x, basket.position.y);
        }
    }


}
