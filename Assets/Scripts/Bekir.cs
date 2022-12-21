using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bekir : MonoBehaviour
{
    private string[] Winter;
    private string girilecekDeger;
    void Start()
    {
        girilecekDeger = "Fire Pit";
        Winter = new string[] {"Fire Pit","Tire Chain","Penguin","Antarctica","Antibiotic","Apical Pneumonia",
                               "Moisturising Cream","Flu","Dry Skin","Vitamin","Hypothermia","December","January",
                               "February","Long Ear","Elves","Reindeer","Santa Claus","Snow Fairy","Feel Cold",
                               "Pomegranate","Noel","New Year","Hockey","Soup","Snowflake","Snowboarding","Hot Chocolate",
                               "Winter Olympics","Hibernation","Ice Skating","White","Short Days","Bobsledding","Beanie",
                               "Chimney","Winter Wonderland","Frost","Glvove", "Snowman", "Shovel","Cold", "Boot", 
                               "Scarf", "Coat" , "Heater", "Storm","Hot Coffee", "Fireplace","Snowball Fight"};  //50




        Debug.Log(kontrolcu(Winter, girilecekDeger));
        Debug.Log(girilecekDeger);
        Debug.Log(Winter.Length);

    }

    public string kontrolcu(string[] kontrolEdilenDizi, string _girilecekDeger) 
    {
        string sonuc = "GÝRÝLEBÝLÝR";

        for (int i = 0; i < kontrolEdilenDizi.Length;i++) 
        {
            if (kontrolEdilenDizi[i]==_girilecekDeger) 
                sonuc = "BU VERÝ GÝRÝLEMEZ";
            
        
        }

        return sonuc;
    }
   
}
