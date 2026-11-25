using UnityEngine;
using UnityEngine.AI;
public class Goblin : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        
    }
}
