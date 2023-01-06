using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    [SerializeField] int _goldAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityGold gold))
        {
            Debug.Log("Picked up gold");
            gold.GainGold(_goldAmount);
        }
    }
}
