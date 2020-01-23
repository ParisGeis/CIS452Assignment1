using UnityEngine;

public class Book : Item, StatIncrease, HealthIncrease
{
    private string text;
    private int numPages;
    private bool isOpen = true;

    public Book(string name, string text, int numPages)
    {
        setName(name);
        this.text = text;
        this.numPages = numPages;
    }

    public override void use()
    {
        if (isOpen)
        {
            Debug.Log(text);
            Debug.Log(getName() + " read");
            boostStat("Intelligence", 15);
            boostHealth(10);
            regenerate(5);
        }
        else
        {
            Debug.Log("The book is closed");
        }
    }

    public void open()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Book opened");
        }
        else
        {
            Debug.Log("Book is already open");
        }
    }

    public void close()
    {
        if (isOpen)
        {
            isOpen = false;
        }
        else
        {
            Debug.Log("Book is already closed");
        }
    }

    public void boostStat(string statName, int boost)
    {
        Debug.Log(statName + " boosted by " + boost);
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
