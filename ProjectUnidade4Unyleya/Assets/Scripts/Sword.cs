using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Enemy") && player.GetComponent<Player>().isAttacking)
        {
            collision.GetComponent<Enemy>().TakeDamage(25f);
        }

        // if (collision.CompareTag("special"))
        // {
        //     collision.GetComponent<SpecialTree>().Destroy(collision.gameObject);

        // }
    }

}
