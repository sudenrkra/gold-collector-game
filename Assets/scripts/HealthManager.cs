using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int health = 3;
    public TextMeshProUGUI healthText;
    public GameObject gameOverPanel;
 


    private bool isTakingDamage = false;

    private void Start()
    {
        UpdateHealthUI();
        gameOverPanel.SetActive(false);
    }

    public void TakeDamage()
    {
        if (!isTakingDamage && health > 0) 
        {
            isTakingDamage = true;
            health -= 1;
            UpdateHealthUI();

            if (health <= 0)
            {
                GameOver();
            }

            Invoke("ResetDamage", 0.5f); 
        }
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    private void ResetDamage()
    {
        isTakingDamage = false;
    }

    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health;
        }
    }
}
