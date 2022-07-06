using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    public static bool GameOver;

    public void SpawnObject()
    {
        Instantiate(prefab, new Vector3(Random.Range(-9f, 9f), 8.5f, 0f), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !GameOver)
        {
            ScoreManager.Instance.AddPoint();
            SpawnObject();
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            GameOver = true;
        }
    }
}