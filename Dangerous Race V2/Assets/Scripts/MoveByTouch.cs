using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
    public float moveSpeed = 200;
    public GameObject character;

    private Rigidbody characterBody;
    private float screenWidth;


    private void Start()
    {
        screenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody>();
    }

    void Update()
    {
        int i = 0;
        //Loop chaque fois qu'il detecte un touch
        while (i < Input.touchCount)
        {
            //Move right
            if (Input.GetTouch(i).position.x > screenWidth / 2)
            {
                RunCharacter(1.0f);
            }

            //Move left
            if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                RunCharacter(-1.0f);
            }
            ++i;
        }
    }

    private void RunCharacter(float horizontalInput)
    {
        //Move Player
        characterBody.AddForce(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0));

    }
}
