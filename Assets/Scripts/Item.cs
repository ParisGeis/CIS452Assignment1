/*
 * Paris Geis
 * Item.cs
 * Assignment 1
 * Abstract class from which Book, Food, and Potion are derived
 */

abstract public class Item
{
    private string name;
    private double weight;
    private int value;

    public abstract void use();

    public void setName(string newName)
    {
        name = newName;
    }
    public string getName()
    {
        return name;
    }
}
