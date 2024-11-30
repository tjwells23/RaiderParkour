using UnityEngine;
using UnityEngine.SceneManagement;

public class resetPlayer : MonoBehaviour
{
    public static resetPlayer Instance;
    public GameObject gameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            //Destroy(gameObject);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ResetGame();
        }
        
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void showGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
}
