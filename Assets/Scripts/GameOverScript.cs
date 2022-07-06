using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton()
    {
        ObjectBehaviour.GameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}