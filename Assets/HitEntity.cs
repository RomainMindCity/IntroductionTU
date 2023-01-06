using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField] int _damageAmount;
    
    private float timer = 0.0f;
    private float maxtimer = 2.0f;
    



    void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        if (timer >= maxtimer)
        {
            timer = 0.0f;
            if (other.TryGetComponent(out EntityHealth entityHealth))
            {
                entityHealth.TakeDamage(_damageAmount);
                HealthUI healthUI = FindObjectOfType<HealthUI>();
                healthUI.UpdateSlider(entityHealth.CurrentHealth);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform parent = other.transform.parent;
            if (parent.TryGetComponent(out EntityHealth health))
            {
                health.TakeDamage(_damageAmount);
            }
        }   
    }
}
