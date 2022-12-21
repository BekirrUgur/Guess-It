using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    private TextMeshProUGUI contentText;
    public GameObject warning;
    public GameObject content;
    private TextMeshProUGUI gameTimeText;
    public GameObject gameTime;
    public GameObject score;
    public GameObject correct;


    static public float timeRemaining;
    public bool timerIsRunning = false;
    private bool gamerTimerIsRunning = false;
    private float gameTimeRemaining;
    private int timeChecked;
    private string[] questions;

    private void Start()

    {
        contentText = content.GetComponent<TextMeshProUGUI>();
        gameTimeText = gameTime.GetComponent<TextMeshProUGUI>();
        // Starts the timer automatically

        timerIsRunning = true;
        timeRemaining = 5;


        #region Game Duration
        timeChecked = PlayerPrefs.GetInt("GameTime");
        if (timeChecked == 0)
        {
            gameTimeRemaining = 30f;          
        }
        else if(timeChecked == 1)
        {
            gameTimeRemaining = 60f;
        }
        else if (timeChecked == 2)
        {
            gameTimeRemaining = 90f;
        }
        #endregion

        DeckChoice();


    }

    void Update()

    {
        #region Prepare Time
        if (timerIsRunning)

        {

            if (timeRemaining > 0)

            {

                timeRemaining -= Time.deltaTime;
                contentText.SetText((Mathf.Round(timeRemaining)).ToString());
                //Debug.Log(timeRemaining);

            }

            else

            {
                
                Debug.Log("Time has run out !");

                PlayerPrefs.SetInt("IsTrue",1);
                timeRemaining = 0;
                timerIsRunning = false;
                warning.SetActive(false);
                contentText.SetText(questions[Random.Range(0,11)]);
                gamerTimerIsRunning = true;
                gameTime.SetActive(true);
                score.SetActive(true);
                correct.SetActive(true);



            }

        }
        #endregion

        #region Game Time
        if (gamerTimerIsRunning) 
        {
            if (gameTimeRemaining > 0) 
            {
                
                    gameTimeRemaining -= Time.deltaTime;
                    gameTimeText.SetText((Mathf.Round(gameTimeRemaining)).ToString()+"'");
                    //Debug.Log("Oyun Süresi: " + gameTimeRemaining);
                 
            }
            else 
            {
                gamerTimerIsRunning = false;
                PlayerPrefs.SetInt("interstitialsControl",1); 
            }
               

        }
        
        #endregion
    }
    public void DeckChoice() // questions isimli dizimize seçmiþ olduðumuz kategoriyi atýyor.
    {

        #region Deck Choice
        int categoriesCheck = PlayerPrefs.GetInt("CategoriesSelection");
        if (categoriesCheck == 0)
        {
            questions = new string[Data.Animals.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Animals[i];
            }
        }
        else if (categoriesCheck == 1)
        {
            questions = new string[Data.Basketball.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Basketball[i];
            }
        }
        else if (categoriesCheck == 2)
        {
            questions = new string[Data.Lotr.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Lotr[i];
            }
        }
        else if (categoriesCheck == 3)
        {
            questions = new string[Data.Marvel.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Marvel[i];
            }
        }
        else if (categoriesCheck == 4)
        {
            questions = new string[Data.Geography.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Geography[i];
            }
        }
        else if (categoriesCheck == 5)
        {
            questions = new string[Data.Professions.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Professions[i];
            }
        }
        else if (categoriesCheck == 6)
        {
            questions = new string[Data.Football.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Football[i];
            }
        }
        else if (categoriesCheck == 7)
        {
            questions = new string[Data.Furniture.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Furniture[i];
            }
        }
        else if (categoriesCheck == 8)
        {
            questions = new string[Data.Famous.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Famous[i];
            }
        }
        else if (categoriesCheck == 9)
        {
            questions = new string[Data.Countries.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Countries[i];
            }
        }
        else if (categoriesCheck == 10)
        {
            questions = new string[Data.Cartoon.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Cartoon[i];
            }
        }
        else if (categoriesCheck == 11)
        {
            questions = new string[Data.Winter.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i] = Data.Winter[i];
            }
        }
        #endregion

    }

}
