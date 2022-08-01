using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string hero = "Mohammed";

        int health = 100;

        print("current health ="+ health);

        int damaged = 20;

        health = health - damaged;

            print("damaged health ="+ health);

        int boost = 10;

        health = health + boost;

            print(+ health + ", the health got damaged then healed by the effect boost");





        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
