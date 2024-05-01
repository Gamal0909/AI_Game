using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class collect : MonoBehaviour
{
    [SerializeField] ScoreScipt sc;
    private void Awake()
    {
        GameObject scoreTextObject = GameObject.FindGameObjectWithTag("ScoreTEXT");
        if (scoreTextObject != null)
        {
            sc = scoreTextObject.GetComponent<ScoreScipt>();
        }

    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sc.IncreaseScore();
            Destroy(gameObject);
        }
    }
    
}
