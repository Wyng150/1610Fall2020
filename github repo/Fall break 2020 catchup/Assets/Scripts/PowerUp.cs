﻿using UnityEngine;
using UnityEngine.Events;
public class PowerUp : MonoBehaviour
{
    public int score;
    public UnityEvent powerUpEvent;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        print(score);
        powerUpEvent.Invoke();
    }
}