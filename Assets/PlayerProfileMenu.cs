using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.TextCore.Text;

public class PlayerProfileMenu : MonoBehaviour
{
    public TextMeshProUGUI usernameText;
    public TextMeshProUGUI playerIDText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI invalidUsernameText;
    public RectTransform usernameTextRectTransform;
    public TMP_InputField newUsernameField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        usernameText.text = "Hello " + PlayerProfileManager.Instance.getUsername() + "!";
        playerIDText.text = "PlayerID: " + PlayerProfileManager.Instance.getPlayerID();
        highscoreText.text = "Highscore: " + PlayerProfileManager.Instance.getHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadChangeUsernameField()
    {
        usernameText.text = "Hello ";
        usernameText.alignment = TextAlignmentOptions.Left;
        invalidUsernameText.gameObject.SetActive(false);

        // Change width of Hello message object to fit new username field
        Vector2 sizeDelta = usernameTextRectTransform.sizeDelta;
        sizeDelta.x = 510;
        usernameTextRectTransform.sizeDelta = sizeDelta;

        // Change x position of Hello message object to fit new username field
        Vector3 position = usernameTextRectTransform.localPosition;
        position.x = 78;
        usernameTextRectTransform.localPosition = position;

        newUsernameField.gameObject.SetActive(true);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void changeUsername()
    {
        //usernameText.text = "Hello " + newUsernameField.text + "!";
        //PlayerProfileManager.Instance.setUsername(newUsernameField.text);
        string newUsername = newUsernameField.text;

        if (!string.IsNullOrEmpty(newUsername))
        {
            if (PlayerProfileManager.Instance.setUsername(newUsername))
            {
                usernameText.text = "Hello " + newUsername + "!";
            }
            else
            {
                invalidUsernameText.gameObject.SetActive(true);
                invalidUsernameText.text = "Invalid username: Must be 1 - 15 characters long and contain only letters or numbers.";
                usernameText.text = "Hello " + PlayerProfileManager.Instance.getUsername() + "!";
            }
        }
        else
        {
            invalidUsernameText.gameObject.SetActive(true);
            invalidUsernameText.text = "Invalid username: Cannot have null or empty username.";
            usernameText.text = "Hello " + PlayerProfileManager.Instance.getUsername() + "!";
        }

        usernameText.alignment = TextAlignmentOptions.Center;

        // Change width of Hello message object back to what it was
        Vector2 sizeDelta = usernameTextRectTransform.sizeDelta;
        sizeDelta.x = 686;
        usernameTextRectTransform.sizeDelta = sizeDelta;

        // Change x position of Hello message object back to what it was
        Vector3 position = usernameTextRectTransform.localPosition;
        position.x = 0;
        usernameTextRectTransform.localPosition = position;

        newUsernameField.gameObject.SetActive(false);
    }
}
