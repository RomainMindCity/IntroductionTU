using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _damageAmount;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform parent = other.transform.parent;
            if (parent.TryGetComponent(out EntityHealth health))
            {
                health.TakeDamage(_damageAmount);
            }
        }
        
    }
}
