using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomEnd : MonoBehaviour
{
    EndGAME end;

    void Start()
    {
        end = FindObjectOfType<EndGAME>();
        if (end == null)
        {
            Debug.LogError("EndGAME component not found!");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (end != null)
            {
                end.EndGame.text = end.Loser;
                end.End();
            }
            else
            {
                Debug.LogError("EndGAME component is not assigned!");
            }
        }
    }
}
