using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Character : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] private float maxLife;
    [SerializeField] private float life;

    void Start()
    {
        maxLife = 100;
        life = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            IsDead();
        }
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
    }

    private void IsDead()
    {
        gameManager.GameOver();
    }
}
