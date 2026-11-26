using UnityEngine;
using System.Collections;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float life;

    public float Life{get{return life;}set{life=value;}}
    
    public void TakeDamage(float damage)
    {
        Life -= damage;

        Debug.Log(Life);
        if (Life <= 0)
        {
            //Destroy(gameObject);
            Debug.Log("Dead!!!");
        }
    }

}
