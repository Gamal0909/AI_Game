using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class EndGAME : MonoBehaviour
{
    public TextMeshProUGUI EndGame;
    public TextMeshProUGUI Sc;
    public GameObject EndGameTMP;
    public GameObject Score;
    public GameObject Health;
    public GameObject BTN;
    public GameObject Backbtn;
    public GameObject Player, Enemy;
    Camera cam;
    Cammove cammove;
    public string Loser = "GameOver";
    public string Winner = "Winner\n The Score :4";

    void Start()
    {
        cam = Camera.main;
        cammove = cam.GetComponent<Cammove>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void End()
    {
        cammove.enabled = false;
        Player.SetActive(false);
        Enemy.SetActive(false);
        EndGameTMP.SetActive(true);
        Score.SetActive(false);
        Health.SetActive(false);
        BTN.SetActive(true);
        Backbtn.SetActive(true);
    }

    public void Active_btn()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }


}
