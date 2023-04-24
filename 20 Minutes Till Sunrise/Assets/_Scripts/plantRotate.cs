using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantRotate : MonoBehaviour
{
    public float speed = 0.3f;

    void Update()
    {
        float rotate = Time.deltaTime * speed;
        transform.Rotate(new Vector3(0, rotate, 0));
    }
}
