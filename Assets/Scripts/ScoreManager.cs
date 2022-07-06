using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public int score;
    public int highscore;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "High Score: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}