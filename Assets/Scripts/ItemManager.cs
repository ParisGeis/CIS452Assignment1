using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    List<Item> itemList = new List<Item>();
    List<Consumable> consumeList = new List<Consumable>();

    public void Start()
    {
        Food hotdog = new Food("hot dog", 8);
        Book warAndPeace = new Book("War and Peace", "\"We can know only that we know nothing.\"", 1215);

        hotdog.taste();
        hotdog.checkIfSpoiled();
        hotdog.use();

        warAndPeace.use();
        warAndPeace.open();
        warAndPeace.close();
        warAndPeace.close();

        Food soup = new Food("bisque", 7);
        Food salad = new Food("Caesar salad", 6);
        Book lifeOfPi = new Book("Life of Pi",
            "\"To choose doubt as a philosophy of life...\"", 356);
        Book littlePrince = new Book("The Little Prince", "\"It is only with the heart " +
            "that one can see rightly...\"", 128);
        Potion mediumPotion = new Potion("Mysterious Vial", 2);

        itemList.Add(soup);
        itemList.Add(salad);
        itemList.Add(lifeOfPi);
        itemList.Add(littlePrince);
        itemList.Add(mediumPotion);

        consumeList.Add(soup);
        consumeList.Add(salad);
        consumeList.Add(mediumPotion);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Item item in itemList)
            {
                item.use();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach(Consumable cons in consumeList)
            {
                cons.consume();
            }
        }
    }
}
