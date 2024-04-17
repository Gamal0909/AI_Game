using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject start;
    [SerializeField] GameObject level;
    [SerializeField] GameObject option;
 

    public void st()
    {
        start.SetActive(false);
        level.SetActive(true);
    }
    public void opt()
    {
        start.SetActive(false);
        option.SetActive(true);
    }
    public void levelback()
    {
        level.SetActive(false);
        start.SetActive(true);
    }
    public void optionback()
    {
        option.SetActive(false);
        start.SetActive(true);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void lvl1()
    {
        SceneManager.LoadScene("Level_1");
    }
}
