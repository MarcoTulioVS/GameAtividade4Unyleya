using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField]
    private float speed; 

    public bool isMoving;
    private void Movement()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    private void Update()
    {
        if(isMoving)
        {
            Movement();
        }
    }

}
