using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;


public class aTarget : MonoBehaviour
{
    public float health = 50f;
    public GameObject enemy;
    public TextMeshProUGUI healths;
    public TextMeshProUGUI enemybartext;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        
        enemy.SetActive(false);
        healths.enabled = false;
        enemybartext.enabled = false;

    }

    public void Life (float amount)
    {
        health += amount;
    }
}
