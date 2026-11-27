using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Animator animHeartIcon;

    public int coins;

    public TextMeshProUGUI coinsText;

    [SerializeField]
    private GameObject uiGameOver;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        UpdateCoinsText();
    }

    public void AddCoins(int value)
    {
        this.coins += value;
        Debug.Log("Coins: " + coins);
    }

    public void UpdateCoinsText()
    {
        coinsText.text = "x" + coins.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowGameOverUI(bool isActive)
    {
        uiGameOver.SetActive(isActive);
    }
}
