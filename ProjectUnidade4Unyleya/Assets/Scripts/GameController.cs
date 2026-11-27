using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Animator animHeartIcon;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }
}
