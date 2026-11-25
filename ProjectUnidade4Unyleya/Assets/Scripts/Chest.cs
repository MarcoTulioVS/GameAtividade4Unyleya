using UnityEngine;
using System.Collections;
public class Chest : MonoBehaviour
{
    public GameObject ghost;

    [SerializeField]
    private Animator anim;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Open();
            StartCoroutine(StartMovement());
        }

    }

    public void Open()
    {
        anim.SetBool("open", true);
    }

    IEnumerator StartMovement()
    {
        yield return new WaitForSeconds(1f);
        ghost.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ghost.GetComponent<Ghost>().isMoving = true;
        
    }
}
