using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    public void TakeDamage(int _damage)
    {
        CurrentHealth -= _damage;
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int _healthAmount)
    {
        Debug.Log("Healed");
        Debug.Log(CurrentHealth);
        CurrentHealth += _healthAmount;
        Debug.Log(CurrentHealth);
        if(CurrentHealth > _maxHealth)
        {
            CurrentHealth = _maxHealth;
        }
        HealthUI healthUI = FindObjectOfType<HealthUI>();
        healthUI.UpdateSlider(CurrentHealth);
    }

    public void PowerUp(int _powerUpAmount)
    {
        _maxHealth += _powerUpAmount;
        Debug.Log(_maxHealth);
        HealthUI healthUI = FindObjectOfType<HealthUI>();
        //update health max value
        healthUI.UpdateSlideCMH(_maxHealth);
        
    }

    public void Die()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
