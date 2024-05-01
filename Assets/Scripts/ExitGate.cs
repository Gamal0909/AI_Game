using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (end != null)
            {
                end.EndGame.text = end.Winner;
                end.End();
            }
            else
            {
                Debug.LogError("EndGAME component is not assigned!");
            }
        }
    }
}
