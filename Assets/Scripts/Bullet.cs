using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float rotateSpeed = 5f;

    public GameObject effec;

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }

    private void OnTriggerEnter2D()
    {
        Instantiate(effec, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
