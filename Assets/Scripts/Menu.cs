using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject start;


    public void st()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void quit()
    {
        Application.Quit();
    }
}
