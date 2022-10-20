using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Management : MonoBehaviour
{
    public GameObject powerUp;
    [Tooltip("Power Ups in the Scene")] public int puScene;
    [HideInInspector] public int posX, posZ;
    [HideInInspector] public int powerUpsDead = 0;

    Vector3 initialPos;
    GameObject player, wallTop, wallDown, wallLeft, wallRight;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //wallTop = GameObject.FindGameObjectWithTag("WallTop");
        //wallDown = GameObject.FindGameObjectWithTag("WallDown");
        //wallLeft = GameObject.FindGameObjectWithTag("WallLeft");
        //wallRight = GameObject.FindGameObjectWithTag("WallRight");

        for (int i = 0; i < puScene; i++)
        {
            Randomized();
            // If the random position is the same as the player, generate a new position
            if (posX == player.transform.position.x || posZ == player.transform.position.z)
            {
                Randomized();
                initialPos = new Vector3(posX, 0.5f, posZ);
                Instantiate(powerUp, initialPos, Quaternion.identity);
            }
            else
            {
                initialPos = new Vector3(posX, 0.5f, posZ);
                Instantiate(powerUp, initialPos, Quaternion.identity);
            }
        }
    }

    void Randomized()
    {
        //posX = Random.Range(((int)wallLeft.transform.position.x), ((int)wallRight.transform.position.x));
        //posZ = Random.Range(((int)wallTop.transform.position.z), ((int)wallDown.transform.position.z));
        posX = Random.Range(-9, 9);
        posZ = Random.Range(-9, 9);
    }
}
