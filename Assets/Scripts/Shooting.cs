using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float  force;
    public GameObject bulletPrefab;
    public Transform shootingPoint;

    private void Start()
    {
        StartCoroutine("Courotine");
    }


    IEnumerator Courotine() 
    {

        yield return new WaitForSeconds(2);
        ShootingSystem();
        StartCoroutine("Courotine");

    }


    void ShootingSystem()
    {

        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * force, ForceMode2D.Impulse);

    }

}
