using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // For camera movements
    private void LateUpdate()
    {
        // Move the camera adding the difference between camera and the player
        transform.position = player.transform.position + offset;
    }
}
