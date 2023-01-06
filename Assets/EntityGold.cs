using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] int _goldAmount;

    public void GainGold(int amount)
    {
        _goldAmount += amount;
        GoldUI goldUI = FindObjectOfType<GoldUI>();
        goldUI.UpdateGold(_goldAmount);
    }

    
}
