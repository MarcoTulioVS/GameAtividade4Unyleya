using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

   void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("star"))
        {
            GameController.instance.AddCoins(10);
            Destroy(collision.transform.parent.gameObject);
        }
    } 
   
}
