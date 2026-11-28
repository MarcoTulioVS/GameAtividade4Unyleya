using UnityEngine;

public class ChestAppear : MonoBehaviour
{
    public GameObject chest;

    void ShowChest()
    {
        if (GameController.instance.GetQuantityTree() == 10)
        {
            chest.SetActive(true);
        }
        
    }

    void Update()
    {
        ShowChest();
    }
}
