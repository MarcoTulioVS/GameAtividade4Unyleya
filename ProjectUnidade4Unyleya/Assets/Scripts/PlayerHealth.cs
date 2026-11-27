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

        if (Life > 20 && Life <= 30)
        {
            GameController.instance.animHeartIcon.SetTrigger("lose");
        }
        else if (Life <= 20)
        {
            GameController.instance.animHeartIcon.SetTrigger("critical");
        }
        
        
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
            yield return new WaitForSeconds(1f);
            GameController.instance.ShowGameOverUI(true);
            StopCoroutine(ExecuteDie());
            
        }
        
        
    }
}
