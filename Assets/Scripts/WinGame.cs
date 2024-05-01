using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject Gate;
    public GameObject ss;
    private ScoreScipt sc;
    private void Start()
    {
        sc = ss.GetComponent<ScoreScipt>();
        Gate.SetActive(false);
    }

    private void Update()
    {
        Winner();    
    }

    void Winner()
    {
       
        if (sc.current_score == 4)
        {
            Gate.SetActive(true);
        }
    }
    
}
