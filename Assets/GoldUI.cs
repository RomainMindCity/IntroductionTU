using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    void Start()
    {
        _text.text = "Gold : 0";
    }

    public void UpdateGold(int newGoldValue)
    {
        _text.text = "Gold : " + newGoldValue.ToString() + "";
    }
}
