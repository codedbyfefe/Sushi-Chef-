using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    //Creating variables that will be used for the code below
    public Text ui;
    public int sushicost = 15;
    public float inflation = 25;

    //Creating a function that will increment the currency produced 
    //each time the player clicks on the sushi
    public void Increment()
    {
        GameManager.sushi += GameManager.multiplier;
    }

    //Creating a function for the purchase of the item
    public void Buy(int ItemNumber)
    {
        if(ItemNumber == 1 && GameManager.sushi >= sushicost)
        {
            GameManager.multiplier += 2;
            GameManager.sushi -= sushicost;
            sushicost = sushicost + (int)(sushicost * inflation / 100);
            Debug.Log("Button has been clicked.");
        }
        else
        {
            Debug.Log("You Dont have enough sushi.");
        }
    }

    //Updates the ui text each time the currency is increased
    public void update()
    {
        ui.text = "Sushi:" + GameManager.sushi;
        Debug.Log("Sushi is being added.");
    }
}
