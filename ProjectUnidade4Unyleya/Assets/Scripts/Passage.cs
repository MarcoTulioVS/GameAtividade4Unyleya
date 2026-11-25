using UnityEngine;

public class Passage : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    public void Open()
    {
        anim.SetBool("open", true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Open();
        }

    }
}
