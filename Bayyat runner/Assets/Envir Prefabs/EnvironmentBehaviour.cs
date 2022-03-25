using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentBehaviour : MonoBehaviour
{
    public float Speed;
    public float Destruction_X_Position;

    void Update()
    {
        if (transform.position.x > Destruction_X_Position)
        {
            transform.position += new Vector3(-Speed * Time.deltaTime, 0, 0);
        }
        else Destroy(gameObject);
    }
}
