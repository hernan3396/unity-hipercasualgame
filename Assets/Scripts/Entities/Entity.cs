using UnityEngine;
using System.Collections;

abstract public class Entity : MonoBehaviour
{
    #region Parameters
    [SerializeField] protected int _currentHealth;
    protected bool _isInmune = false;
    protected float _inmunityTime;
    protected int _maxHealth;
    #endregion

    public virtual void TakeDamage(int value, int knockback)
    {
        if (_isInmune) return;
        _isInmune = true;

        _currentHealth -= value;

        if (_currentHealth <= 0)
        {
            StartDeath();
            return;
        }
    }

    protected abstract void StartDeath();

    public abstract void Death();

    public bool GetIsInmune
    {
        get { return _isInmune; }
        set { _isInmune = value; }
    }
}
