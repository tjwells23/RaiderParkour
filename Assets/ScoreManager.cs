using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component
    public TextMeshProUGUI highScoreText;
    private int playerScore = 0;
    private int highScore = 0;
    private void Awake()
    {
        // Set up the singleton instance.
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            //Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Load the high score from PlayerPrefs (persistent storage)
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreDisplay();

    }

    public void addScore(int points)
    {
        playerScore += points;
        UpdateScoreDisplay();

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("HighScore", highScore); // Save the new high score
            UpdateHighScoreDisplay(); 
        }

    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + playerScore.ToString(); // Update the UI text with the current score
    }

    private void UpdateHighScoreDisplay()
    {
        highScoreText.text = "High Score: " + highScore.ToString(); // Update the UI text with the high score
    }
}
