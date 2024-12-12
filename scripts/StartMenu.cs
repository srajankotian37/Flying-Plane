using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Text scoreText;  // Reference to the score UI Text

    void Start()
    {
        // Load and display the score when the start menu scene is loaded
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = $"Score: {score}";
    }

    void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
