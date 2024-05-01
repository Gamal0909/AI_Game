using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmyActive : MonoBehaviour
{
    public GameObject Enemy;
    public int time = 2;
    private void Awake()
    {
        Enemy.SetActive(false);
        Invoke("EnemyActive", time);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemyActive()
    {
        Enemy.SetActive(true);
    }
}
