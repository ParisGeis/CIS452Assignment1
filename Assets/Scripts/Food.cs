/*
 * Paris Geis
 * Food.cs
 * Assignment 1
 * Concrete class for ItemManager.cs
 */

using UnityEngine;

public class Food : Item, Consumable, HealthIncrease
{
    private int tastiness = 5;
    private bool spoiled = false;

    public Food(string name, int tastiness)
    {
        setName(name);
        this.tastiness = tastiness;
    }

    public override void use()
    {
        Debug.Log(getName() + " eaten");
        consume();
        boostHealth(20);
        regenerate(10);
    }

    //return tastiness value
    public int taste()
    {
        Debug.Log("This " + getName() + " tastes like a " + tastiness + " out of 10");
        return tastiness;
    }

    //return spoiled
    public bool checkIfSpoiled()
    {
        Debug.Log("Is this " + getName() + " spoiled? " + spoiled);
        return spoiled;
    }

    public void consume()
    {
        Debug.Log(getName() + " removed from inventory");
    }

    public void boostHealth(int boost)
    {
        Debug.Log("Health boosted by " + boost);
    }

    public void regenerate(int duration)
    {
        Debug.Log("Health will regenerate for " + duration + " minutes");
    }
}
