using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Goblin : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Animator anim;

    private bool isReady;
    
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
        Debug.Log(distance);

        if(distance <= 5f)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);

            if(distance <= 2f)
            {
                Attack();
            }

        }
        else
        {
            
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
}
