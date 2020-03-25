using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] startModule;
    public GameObject[] moduleList;
    public GameObject playerRef;

    public float distanceMin = 10;

    private List<GameObject> addedModules;

    Vector3 tileOffset = Vector3.zero;


    public bool inPlay = true;


    void Start()
    {
        inPlay = false;

        addedModules = new List<GameObject>();
        for (int i = 0; i < 4; i++)
        {
            AddFirstModule();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(playerRef.transform.position, tileOffset) < distanceMin)
        {
            if (!inPlay)
            {
                AddFirstModule();
                RemoveFirstModule();
            }

            else
            {
                inPlay = true;
                AddModule();
                RemoveFirstModule();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            inPlay = true;
        }
    }


    void RemoveFirstModule()
    {
        GameObject firstModule = addedModules[0];
        addedModules.Remove(firstModule);
        Destroy(firstModule);  
    }


    void AddModule()
    {
        GameObject tilePrefab = RandomModule();

        float moduleWidth = tilePrefab.GetComponent<Module>().width;
        tileOffset.z += moduleWidth / 2;

        GameObject newModule = Instantiate(tilePrefab, tileOffset, Quaternion.identity, transform);

        addedModules.Add(newModule);
        tileOffset.z += moduleWidth / 2;
    }


    void AddFirstModule()
    {
        GameObject tilePrefab = RandomStartModule();

        float moduleWidth = tilePrefab.GetComponent<Module>().width;
        tileOffset.z += moduleWidth / 2;

        GameObject newModule = Instantiate(tilePrefab, tileOffset, Quaternion.identity, transform);

        addedModules.Add(newModule);
        tileOffset.z += moduleWidth / 2;
    }


    GameObject RandomModule()
    {
        int randomIndex = Random.Range(0, moduleList.Length);
        return moduleList[randomIndex];
    }

    GameObject RandomStartModule()
    {
        int randomIndex = Random.Range(0, startModule.Length);
        return startModule[randomIndex];
    }
}