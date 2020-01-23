using UnityEngine;

public class Potion : Item, Consumable, StatIncrease
{
    private int fluidOz;

    public Potion(string name, int fluidOz)
    {
        setName(name);
        this.fluidOz = fluidOz;
    }

    public void boostStat(string statName, int boost)
    {
        Debug.Log(statName + " boosted by " + boost);
    }

    public void consume()
    {
        Debug.Log(getName() + " removed from inventory");
    }

    public override void use()
    {
        Debug.Log(getName() + " drunk");
        consume();
        boostStat("Stamina", 25);
    }
}
