using UnityEngine;
using System.Collections;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float life;

    public float Life{get{return life;}set{life=value;}}
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Life -= damage;

        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
