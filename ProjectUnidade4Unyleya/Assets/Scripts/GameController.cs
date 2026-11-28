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

    [SerializeField]
    private int treeQuantity;

    public GameObject uiLevelComplete;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu")
        {
            UpdateCoinsText();
        }
        
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

    public void ExitGame()
    {
        Application.Quit();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AddQuantityTree()
    {
        treeQuantity++;
    }

    public int GetQuantityTree()
    {
        return treeQuantity;
    }

    public void ShowUILevelComplete(bool isActive)
    {
        uiLevelComplete.SetActive(isActive);
    }
}
