using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    [SerializeField] int _powerUpAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityHealth health))
        {
            health.PowerUp(_powerUpAmount);
        }
    }
}
