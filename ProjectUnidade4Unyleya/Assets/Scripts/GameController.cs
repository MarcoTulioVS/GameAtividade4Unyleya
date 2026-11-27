using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Animator animHeartIcon;

    public int coins;

    public TextMeshProUGUI coinsText;
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
}
