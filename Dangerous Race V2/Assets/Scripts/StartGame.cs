using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject StartInterface;
    // Start is called before the first frame update

    public void CloseStartInterface()
    {
        StartInterface.SetActive(false);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
