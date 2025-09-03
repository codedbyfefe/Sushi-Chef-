using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Creating varibale that will be used in click script
    // for reference and to manage the variables
    public static int sushi;
    public static int multiplier;

    //This is called once the game has started
    void Start()
    {
        multiplier = 1;
        sushi = 1;
        
    }

    
}
