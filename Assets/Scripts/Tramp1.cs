using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp1 : MonoBehaviour
{
    public float rotateSpeed = 5f;

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }

}
