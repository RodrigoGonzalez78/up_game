using UnityEngine;

public class Sierra : MonoBehaviour
{
    public Transform pointOne;
    public Transform pointTwo;
    private Transform target;

    public float rotateSpeed = 5f;
    public float speed = 2;


    private void Start()
    {
        target = pointTwo;
    }

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);

        if (Vector2.Distance(transform.position, target.position) > 0f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }


        if (Vector2.Distance(transform.position, target.position) == 0f && target == pointTwo)
        {
            target = pointOne;

        } else if (Vector2.Distance(transform.position, target.position) == 0f && target == pointOne) 
        {
            target = pointTwo;

        }

    }


}
