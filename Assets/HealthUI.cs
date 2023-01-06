using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;

    int CachedMaxHealth { get; set; }

    public void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {CachedMaxHealth}";
    }

    public void UpdateSlideCMH(int newMaxHealthValue)
    {
        _slider.maxValue = newMaxHealthValue;
        _text.text = $"{_playerHealth.CurrentHealth} / {newMaxHealthValue}";
        CachedMaxHealth = newMaxHealthValue;
    }

    void Start()
    {
        CachedMaxHealth = _playerHealth.CurrentHealth;
        UpdateSlider(_playerHealth.CurrentHealth);
    }   


}
