using UnityEngine;
using System.Collections;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float life;

    public float Life{get{return life;}set{life=value;}}

    private bool isReady;
    
    public void TakeDamage(float damage)
    {
        Life -= damage;

        
        if (Life <= 0)
        {
            StartCoroutine(ExecuteDie());
        }
    }

    public void Die()
    {
        gameObject.GetComponent<Animator>().SetTrigger("dead");
    }

    IEnumerator ExecuteDie()
    {
        if (!isReady)
        {
            
            yield return new WaitForSeconds(1f);
            Die();
            isReady = true;
            StopCoroutine(ExecuteDie());
        }
        
        
    }
}
