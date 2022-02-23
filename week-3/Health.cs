using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    int currentHealth;
    [SerializeField] int maxHealth = 1;
    [SerializeField] UnityEvent damageTrigger;
    [SerializeField] UnityEvent deathTrigger;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public void Damage(int n)
    {
        currentHealth -= n;

        if(currentHealth <= 0)
        {
            Kill();
        } else
        {
            damageTrigger.Invoke();
        }
    }

    public void Kill()
    {
        deathTrigger.Invoke();
    }


    public void Heal(int n)
    {
        currentHealth += n;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void MaxHeal()
    {
        currentHealth = maxHealth;
    }

}
