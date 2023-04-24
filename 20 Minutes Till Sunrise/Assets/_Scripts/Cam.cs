using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
   
    public Transform playerTransform;
    public PlayerController player;

    public float smooth = 0.3f;
    public float height;

    public Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (player) {
            Vector3 pos = new Vector3();
            pos.x = playerTransform.position.x;
            pos.z = playerTransform.position.z;
            pos.y = playerTransform.position.y + height;

            transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
        }


    }
}
