using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Character : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private int life;

    void Start()
    {
        life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            IsDead();
        }
    }

    public void IsDead()
    {
        //No se, ponele que le avisa al game manager xd
    }
}
