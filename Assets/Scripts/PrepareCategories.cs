using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PrepareCategories : MonoBehaviour
{
    public GameObject info;
    private TextMeshProUGUI infoText;

    public Image background;

    private void Start()
    {
        infoText = info.GetComponent<TextMeshProUGUI>();
        int check = PlayerPrefs.GetInt("CategoriesSelection");
        if(check == 0) 
        {
            //Animals
            infoText.SetText("Compete with your friends by trying to explain different animal species.");
            background.color = new Color32(113, 43, 117, 255);
        }
        else if (check == 1) 
        {
            //Basketball
            infoText.SetText("Get ready for a list of the most famous basketball players, especially for basketball fans.");
            background.color = new Color32(137, 15, 13, 255);
        }
        else if (check == 2)
        {
            //Lotr
            infoText.SetText("An exciting category of dozens of characters for true Lord of The Rings fans");
            background.color = new Color32(137, 15, 13, 255);
        }
        else if (check == 3)
        {
            //Marvel
            infoText.SetText("If you like superheroes and follow the Marvel universe, this category is definitely for you.");
            background.color = new Color32(54, 21, 0, 255);
        }
        else if (check == 4)
        {
            //Geography
            infoText.SetText("Are you ready to test your geography knowledge with your friends? Then it's time to compete with famous architectural works.");
            background.color = new Color32(113, 43, 117, 255);
        }
        else if (check == 5)
        {
            //Professions
            infoText.SetText("Let's see how much you and your friends dominate the business world. It's time to discover dozens of different professions.");
            background.color = new Color32(137, 15, 13, 255);
        }
        else if (check == 6)
        {
            //Football
            infoText.SetText("Wasn't the 2022 World Cup so exciting? Now it's time to find out how well your friends follow football");
            background.color = new Color32(137, 15, 13, 255);
        }
        else if (check == 7)
        {
            //Art
            infoText.SetText("What do you see when you look around you right now? Lots of stuff? Yes, the category you are playing consists entirely of what you see.");
            background.color = new Color32(54, 21, 0, 255);
        }
        else if (check == 8)
        {
            //Famous
            infoText.SetText("A category that consists of dozens of movie, art, music stars that you will be excited about with each new name.");
            background.color = new Color32(113, 43, 117, 255);
        }
        else if (check == 9)
        {
            //Countries
            infoText.SetText("Do you like to travel abroad? If your answer is yes, this category should be very easy for you, we hope your friends are also people who like to go abroad :)");
            background.color = new Color32(137, 15, 13, 255);
        }
        else if (check == 10)
        {
            //Cartoon
            infoText.SetText("Get ready to step into the category of cartoons that take us to other worlds, the best moments of childhood.");
            background.color = new Color32(137, 15, 13, 255);
        }
        else if (check == 11)
        {
            //Winter
            infoText.SetText("Brrrrrr! Isn't it too cold? In order not to catch a cold ... you must remember to take it. Oh I almost said one of the answers. Good luck in this cold category!");
            background.color = new Color32(54, 21, 0, 255);
        }



    }

}
