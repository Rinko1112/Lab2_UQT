using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject eggPrefab; // Gán Prefab quả trứng trong Inspector
    public Transform eggSpawnPoint; // Điểm sinh ra trứng
    public float layEggInterval = 3f; // Thời gian giữa các lần đẻ trứng

    private void Start()
    {
        InvokeRepeating("LayEgg", 2f, layEggInterval); // Gọi hàm đẻ trứng theo khoảng thời gian
    }

    void LayEgg()
    {
        if (eggPrefab != null && eggSpawnPoint != null)
        {
            Instantiate(eggPrefab, eggSpawnPoint.position, Quaternion.identity);
        }
    }
}
