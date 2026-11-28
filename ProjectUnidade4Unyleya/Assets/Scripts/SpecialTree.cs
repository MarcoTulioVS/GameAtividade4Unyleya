using UnityEngine;

public class SpecialTree : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "sword" && player.GetComponent<Player>().isAttacking)
        {
            GameController.instance.AddQuantityTree();
            Destroy(gameObject);
        }
    }
}
