using System.Text.RegularExpressions;
using System.Xml;
using UnityEngine;

public class PlayerProfileManager : MonoBehaviour
{
    private const string usernameKey = "Username";
    private const string highScoreKey = "HighScore";
    private const string playerIDKey = "PlayerID";
    public static PlayerProfileManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            //Destroy(gameObject);
        }

        initializePlayerProfile();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void initializePlayerProfile()
    {
        // Assign default username if not set
        if (!PlayerPrefs.HasKey(playerIDKey))
        {
            PlayerPrefs.SetString(usernameKey, "Player1");
            PlayerPrefs.SetInt(highScoreKey, 0);
            string uniqueID = generateRandomPlayerID();
            PlayerPrefs.SetString(playerIDKey, uniqueID);

        }
    }

    public string getUsername()
    {
        return PlayerPrefs.GetString(usernameKey);
    }

    public string getPlayerID()
    {
        return PlayerPrefs.GetString(playerIDKey);
    }

    public bool setUsername(string newUsername)
    {
        if (isValidUsername(newUsername))
        {
            PlayerPrefs.SetString(usernameKey, newUsername);
            return true;
        }
        else
        {
            //Debug.LogError("Invalid username: Must be 1-15 characters long and contain only letters or numbers.");
            return false;
        }
    }

    public int getHighScore()
    {
        return PlayerPrefs.GetInt(highScoreKey);
    }

    public void setHighScore(int newHighScore)
    {
        PlayerPrefs.SetInt(highScoreKey, newHighScore);
    }

    private bool isValidUsername(string username)
    {
        // Check length
        if (string.IsNullOrEmpty(username) || username.Length > 15)
        {
            return false;
        }

        // Check if only alphanumeric characters
        Regex regex = new Regex("^[a-zA-Z0-9]+$");
        return regex.IsMatch(username);
    }

    private string generateRandomPlayerID()
    {
        string playerID = "";

        for (int i = 0; i < 5; i++)
        {
            int randomDigit = Random.Range(0, 10); // Random number between 0 and 9
            playerID += randomDigit;
        }

        return playerID;
    }
}
