using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject EggBroken; // Prefab trứng vỡ

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground") || col.gameObject.CompareTag("platform"))
        {
            BreakEgg(); // Gọi hàm làm vỡ trứng
        }
        else if (col.gameObject.CompareTag("box"))
        {
            Destroy(gameObject); // Xóa trứng nếu chạm vào hộp
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Basket"))
        {
            Destroy(gameObject); // Trứng biến mất khi rơi vào thùng
            // Có thể thêm điểm số tại đây nếu cần
        }
    }

    void BreakEgg()
    {
        Debug.Log("Egg is breaking!");
        if (EggBroken != null)
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
 

}
