using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private int health = 100;
    private int level = 25;
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
     print("Здоровье игрока" + health);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
