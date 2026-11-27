using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour
{
    private float movementForward;
    private float rotateMovement;
    
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed = 100f;

    [SerializeField]
    private Animator anim;

    private bool isReady;

    public bool isAttacking = false;

    public bool isDefending = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
        //StartCoroutine(ExecuteAttack());
        Attack();
        Defend();
    }

    public void Movement()
    {
        movementForward = Input.GetAxis("Vertical");
        rotateMovement = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, movementForward * speed * Time.deltaTime));
        transform.Rotate(new Vector3(0,rotateMovement*rotationSpeed*Time.deltaTime,0));
        
        if(movementForward != 0)
        {
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }

    public void Attack()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            isAttacking = true;
            StartCoroutine(ExecuteAttack());
        }
    }

    public void Defend()
    {
        if(Input.GetMouseButton(1))
        {
            isDefending = true;
            anim.SetBool("defend",true);
        }
        else
        {
            isDefending = false;
            anim.SetBool("defend",false);
        }
    }

    IEnumerator ExecuteAttack()
    {
        if(!isReady)
        {
            isReady = true;
            anim.SetTrigger("attack");
            yield return new WaitForSeconds(0.5f);
            isReady = false;
            //StopCoroutine(ExecuteAttack());
            

        }
    }
}
