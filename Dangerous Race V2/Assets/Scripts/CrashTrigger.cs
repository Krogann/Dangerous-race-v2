using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashTrigger : MonoBehaviour
{
    //Script à mettre sur le Player


    public CameraEffect cameraShakeRef;
    public CarMovement carMovementRef;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            print("CRASH");
            StartCoroutine(cameraShakeRef.Shake(.15f, .4f));
            StartCoroutine(gameOver());


        }
    }

    IEnumerator gameOver()
    {
        carMovementRef.enabled = true;
        cameraShakeRef.enabled = false;

        yield return new WaitForSeconds(3);

        //gameOverMenu.SetActive(true);
    }
}
