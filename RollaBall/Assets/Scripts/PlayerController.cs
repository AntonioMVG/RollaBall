using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Management manage;

    private Rigidbody rb;
    private float movementX, movementY;

    public float speed;

    public TMP_Text puTotal, pickedUp;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        puTotal.text = "Power Ups: " + manage.puScene.ToString();
        Debug.Log("Power Ups: " + manage.puScene);
    }
    /// <summary>
    /// Event to control de Input movements
    /// </summary>
    /// <param name="movementValue">movementValue = WASD</param>
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            manage.powerUpsDead += 1;
            pickedUp.text = "Collected: " + manage.powerUpsDead.ToString();
            Debug.Log("Collected: " + manage.powerUpsDead.ToString());
            //rb.gameObject.transform.localScale += new Vector3(1, 1, 1);
            //speed -= 3;
        }
    }
}
