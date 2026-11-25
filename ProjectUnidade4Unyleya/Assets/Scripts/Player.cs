using UnityEngine;

public class Player : MonoBehaviour
{
    private float movementForward;
    private float rotateMovement;
    
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed = 100f;
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        movementForward = Input.GetAxis("Vertical");
        rotateMovement = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, 0, movementForward * speed * Time.deltaTime));
        transform.Rotate(new Vector3(0,rotateMovement*rotationSpeed*Time.deltaTime,0));
    }
}
