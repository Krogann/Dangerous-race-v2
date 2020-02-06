using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Vector3 spawnCoordinates;
    public float spawnWait;
    public float maxTimeWait;
    public float minTimeWait;
    public int startWait;
    public bool stop;

    int randEnemy;


    private void Start()
    {
        StartCoroutine(WaitSpawner());
    }

    void Update()
    {
    }

    IEnumerator WaitSpawner()
    {
        //yield return: break the program
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            print("Spawn");
            randEnemy = Random.Range(0, Enemies.Length);

            //TODO: controler le spawnPosition pour q le player puissse sortir
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnCoordinates.x, spawnCoordinates.x),
                                                1, Random.Range(-spawnCoordinates.z, spawnCoordinates.z));

            Instantiate(Enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            spawnWait = Random.Range(minTimeWait, maxTimeWait);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}