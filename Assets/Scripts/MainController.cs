using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameOverScript gameOverScript;

    private void Update()
    {
        if (ObjectBehaviour.GameOver)
        {
            gameOverScript.Setup(ScoreManager.Instance.score);
        }
    }
}