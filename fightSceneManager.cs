using System;
using UnityEngine;

public class fightSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CoreSingleton.thePlayer = new Player("Mike");
        Fight f = new Fight();
        f.startFight();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
