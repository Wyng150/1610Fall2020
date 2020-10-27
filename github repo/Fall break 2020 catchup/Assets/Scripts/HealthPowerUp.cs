using UnityEngine;
using UnityEngine.Events;
public class HealthPowerUp : MonoBehaviour
{
    public int health;
    public UnityEvent healthPowerUp;
    
    private void OnTriggerEnter(Collider other)
    {
        health++;
        print(health);
        healthPowerUp.Invoke();
    }
}
