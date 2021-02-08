using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float speed = 3f;
    float hAxis;
    float vAxis;

    void Update()
    {
        Move();
    }

    void Move()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        transform.position += new Vector3(hAxis * speed * Time.deltaTime, 0f, vAxis * speed * Time.deltaTime);
    }
}
