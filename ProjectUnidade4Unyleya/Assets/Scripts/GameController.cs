using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Animator animHeartIcon;

    public int coins;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }

    public void AddCoins(int value)
    {
        this.coins += value;
        Debug.Log("Coins: " + coins);
    }
}
