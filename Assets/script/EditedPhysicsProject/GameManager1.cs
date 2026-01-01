using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


        // public TextMeshProUGUI scoreText;

    public int score = 0;
    public int lives = 5;
    public GrafitiWall grafitiWall;
public int maxLives = 5;
public TextMeshProUGUI scoreText;
public TextMeshProUGUI livesText;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

public void AddScore(int amount)
{
    score += amount;
    Debug.Log("Score: " + score);

    UpdateUI();
}

public void LoseLife(int amount = 1)
{
    lives -= amount;
    lives = Mathf.Clamp(lives, 0, maxLives);

    int wallState = maxLives - lives;
    grafitiWall.SetWallState(wallState);

    UpdateUI();

    if (lives <= 0)
        GameOver();
}
void GameOver()
{
    AudioManager.Instance.PlayGameOverMusic();
    UIManager.Instance.ShowGameOver();
}


public void ResetGame()
{
    score = 0;
    lives = maxLives;

    if (grafitiWall != null)
        grafitiWall.SetWallState(0);
}
void UpdateUI()
{
    if (scoreText != null)
        scoreText.text = "Score: " + score;

    if (livesText != null)
        livesText.text = "Lives: " + lives;
}

}

