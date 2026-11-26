using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.AI.NavMeshAgent agent;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Animator anim;

    private bool isReady;

    [SerializeField]
    private float life;

    public float Life{get{return life;}set{life=value;}}
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
        
    }

    public void Movement()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        //Debug.Log(distance);

        if(distance <= 5f)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);
            anim.SetBool("move", true);

            if(distance <= 2f)
            {
                Attack();
            }

        }
        else
        {
            anim.SetBool("move", false);
            agent.isStopped = true;
            
        }
    }

    public void Attack()
    {
        StartCoroutine(ExecuteAttack());
    }

    IEnumerator ExecuteAttack()
    {
        if(!isReady)
        {
            isReady = true;
            anim.SetTrigger("attack");
            yield return new WaitForSeconds(1f);
            isReady = false;
        }
        
    }

    public void TakeDamage(float damage)
    {
        Life-= damage;
        Debug.Log(Life);
        
        if (Life <= 0)
        {
            anim.SetBool("move", false);
            anim.SetTrigger("dead");
            isReady = true;
            StopCoroutine(ExecuteAttack());
            Destroy(gameObject, 1f);
        }
    }
}
