using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable() => 
        _player.HealthChanged += OnHealthChanged;

    private void OnDisable() => 
        _player.HealthChanged -= OnHealthChanged;

    private void OnHealthChanged(int health, int maxHealth)
    {
        var endValue = (float)health / maxHealth;
        _slider.DOValue(endValue, 1f).Play();
    }
}