using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string heroName = "ahmad";
    int heroPower = 10;
    string villainName = "Khaled";
    int villainPower = 5;
    float playerSpeed = 9.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villainPower)
        {
            print("heroPower");
        }
        else if (heroPower == villainPower)
        {
            print("hero power equal villain power ");
        }
        else
        {
            print("villainPower");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetSpeed(float newSpeed)
    {
        print("old speed is " + playerSpeed);
        playerSpeed = newSpeed;
        print("new speed is " + newSpeed);
    }
}
