using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] int _healthAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityHealth health))
        {
            health.Heal(_healthAmount);
        }
    }
}
