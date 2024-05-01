using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impediment : MonoBehaviour
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
        float distance = Vector3.Distance(transform.position, Player.position);
        if ((int)distance <= 2)
        {
            GetDamge();        
        }
    }

    void GetDamge() {
        healthscript.Decrease_Health();
        Player.rotation = Quaternion.Euler(0, 0, 0);
        Vector3 newPosition = Player.position;
        newPosition.x -= 6;
        Player.position = newPosition;
    }
}
