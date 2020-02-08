using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [Range(-200, 200)]
    public float speed = 5f;
    public float timeLaps = 30.0f;
    public float addSpeed = 1.0f;
    private float delta;
    Rigidbody Car;

    public float timeForDestroy = 8f;

    // Start is called before the first frame update
    void Start()
    {
        float delta = timeLaps;
        //Car = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        delta -= Time.deltaTime;
        if (delta < 0)
        {
            speed = addSpeed;
            delta = timeLaps;
        }

        StartCoroutine(waitDestroy());

        //if (transform.position.z < -30.0f)
        //{
        //    Destroy(gameObject);
        //}


        ////Car.AddForce(movement.normalized * speed * Time.deltaTime);
    }

    IEnumerator waitDestroy()
    {
        yield return new WaitForSeconds(timeForDestroy);
        Destroy(gameObject);
    }
}