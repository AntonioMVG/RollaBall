using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime * speed);
    }
}
