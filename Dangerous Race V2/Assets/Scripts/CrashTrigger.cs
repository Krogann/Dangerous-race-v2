using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashTrigger : MonoBehaviour
{
    //Script à mettre sur le Player


    public CameraShake cameraShakeRef;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            print("CRASH");
            StartCoroutine(cameraShakeRef.Shake(.15f, .4f));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
