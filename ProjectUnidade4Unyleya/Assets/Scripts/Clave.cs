using UnityEngine;

public class Clave : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(10f);
            
        }
    }
}
