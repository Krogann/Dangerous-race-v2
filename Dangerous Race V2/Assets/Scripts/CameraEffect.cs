using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffect : MonoBehaviour
{

    //Script à mettre sur la camera.
    //Creer un un gameObject Empty en parent pour la caméra a la même position que la caméra. 



    //CAMERA SHAKE CRASH
    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalpos = transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-2f, 2f) * magnitude;
            float y = Random.Range(-2f, 2f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalpos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalpos;
    }

    //CAMERA FOLLOW
    //Creer 2 game Object empty pour cameraTarget et LookTarget
    public Transform cameraTarget;
    public float sSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;

    void FixedUpdate()
    {
        Vector3 dPos = cameraTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }

}
