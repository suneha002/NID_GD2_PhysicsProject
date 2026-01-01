using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject startPanel;
    public GameObject gameOverPanel;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        ShowStart();
    }

    public void ShowStart()
    {
        Time.timeScale = 0f; 
        startPanel.SetActive(true);
        gameOverPanel.SetActive(false);
    }

    public void StartGame()
{
    Time.timeScale = 1f;
    startPanel.SetActive(false);

    AudioManager.Instance.PlayStartClick();     
    AudioManager.Instance.PlayBackgroundMusic(); 
}

    public void ShowGameOver()
    {
        Time.timeScale = 0f; 
        
        gameOverPanel.SetActive(true);
    }

 public void RestartGame()
{
    Time.timeScale = 1f;

    AudioManager.Instance.PlayStartClick(); 
    
    AudioManager.Instance.PlayBackgroundMusic(); 
    

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

}
