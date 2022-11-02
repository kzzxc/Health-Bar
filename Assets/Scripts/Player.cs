using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
  [SerializeField] private int _minHealth;
  [SerializeField] private int _maxHealth;

  private int _currentHealth;
  
  public event UnityAction<int, int> HealthChanged; 

  private void Start()
  {
    _currentHealth = _maxHealth;
  }

  public void ChangeHealthValue(int value)
  {
    _currentHealth += value;
    
    if (_currentHealth > _maxHealth) 
      _currentHealth = _maxHealth;
    
    else if (_currentHealth < _minHealth)
      _currentHealth = _minHealth;
    
    HealthChanged?.Invoke(_currentHealth, _maxHealth);
  }
}