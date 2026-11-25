using UnityEngine;

public class Passage : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Open()
    {
        anim.SetBool("open", true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Open();

    }
}
