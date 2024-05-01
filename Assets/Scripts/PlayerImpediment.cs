using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImpediment : MonoBehaviour
{

    HealthScript healthscript;
    Transform Player;
    private void Awake()
    {
        GameObject HealthTextObject = GameObject.FindGameObjectWithTag("HealthTEXT");
        if (HealthTextObject != null)
        {
            healthscript = HealthTextObject.GetComponent<HealthScript>();
        }
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Player = player.GetComponent<Transform>();
        }
        

    }
    void Update()
    {
        float Impeddistance = Vector3.Distance(transform.position, Player.position);
        
        if ((int)Impeddistance <= 3)
        {
            GetDamge();        
        }
    }

    void GetDamge() {
        healthscript.Decrease_Health();
    }
}
