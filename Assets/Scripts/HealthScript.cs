using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    EndGAME end;
    public TextMeshProUGUI txt_Health;
    private int start_Health = 100;
    public int current_Health;
    public int damge = 10;
    // Start is called before the first frame update
    void Start()
    {
        current_Health = start_Health;
        UpdateHealth();
        end = FindObjectOfType<EndGAME>();
        if (end == null)
        {
            Debug.LogError("EndGAME component not found!");
        }
    }
    public void Decrease_Health()
    {
        current_Health -= damge;
        UpdateHealth();
        if (current_Health <= 0)
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
    void UpdateHealth()
    {
        txt_Health.text = "Health: " + current_Health.ToString();
    }
}
