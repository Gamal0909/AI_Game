using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    HealthScript healthscript;
    public Transform Player;
    public Transform Enemy;
    // Start is called before the first frame update
    void Start()
    {
        GameObject HealthTextObject = GameObject.FindGameObjectWithTag("HealthTEXT");
        if (HealthTextObject != null)
        {
            healthscript = HealthTextObject.GetComponent<HealthScript>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GetDamge();
    }
    bool AttackCheck()
    {
        float Enemydistance = Vector3.Distance(Enemy.position, Player.position);
        if(Enemydistance <= 2.6f)
        {
            return true;
        }
        return false;
    }

    void GetDamge() {
        if (AttackCheck())
        {
            healthscript.Decrease_Health();
            Enemy.rotation = Quaternion.Euler(0, 0, 0);
            Vector3 newPosition = Enemy.position;
            newPosition.x -= 6;
            Enemy.position = newPosition;
        }
    }
}
