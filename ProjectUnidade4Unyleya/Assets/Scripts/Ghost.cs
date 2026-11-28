using UnityEngine;
using System.Collections;
public class Ghost : MonoBehaviour
{
    [SerializeField]
    private float speed; 

    public bool isMoving;
    private void Movement()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        StartCoroutine(Vanish());
    }

    private void Update()
    {
        if(isMoving)
        {
            Movement();
        }
    }

    IEnumerator Vanish()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

}
