using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayControl : MonoBehaviour
{
    public Image backGround;
    private TextMeshProUGUI contentText;
    public GameObject content;
    public TextMeshProUGUI scoreText;
    public AudioSource sfx;
    public AudioClip correct;
    public AudioClip pass;

    public bool isTrue;
    private int correctScore;
    private string[] questions;
    private string QuestinSpawnControl = "";
    int sfxControl;

    private void Awake()
    {
        isTrue = false;
        correctScore = 0;
    }
    void Start()
    {
        
        contentText = content.GetComponent<TextMeshProUGUI>();
        backGround.color = Color.black;
        PlayerPrefs.SetInt("GameScore", 0);
        correctScore = PlayerPrefs.GetInt("GameScore");
        scoreText.SetText(correctScore.ToString());
        sfxControl = PlayerPrefs.GetInt("GameSoundEffect");

        StartCoroutine(CoIsTrueStart());
        DeckChoice();

    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning("ÇARPTI");
        if (other.gameObject.tag == "Red" && isTrue == true) 
        {
        
            backGround.color = Color.red;
            PlayerPrefs.SetInt("GameScore", correctScore);
            if (sfxControl == 1) { sfx.PlayOneShot(pass); } // SFX açýk mý kapalý mý kontrol ediyor.
            else { }

            //contentText.SetText(questions[Random.Range(0, 11)]);
            QuestinSpawn();
            isTrue = false;
            StartCoroutine(CoIsTrue());
            StartCoroutine(CoBackgroundBlack());
        }
        if (other.gameObject.tag == "Green" && isTrue == true) 
        {
            backGround.color = Color.green;
            correctScore += 1;
            PlayerPrefs.SetInt("GameScore", correctScore);
            scoreText.SetText(correctScore.ToString());

            if (sfxControl == 1) { sfx.PlayOneShot(correct); } // SFX açýk mý kapalý mý kontrol ediyor.
            else { }

            //contentText.SetText(questions[Random.Range(0, 11)]);
            QuestinSpawn();
            isTrue = false;
            StartCoroutine(CoIsTrue());
            StartCoroutine(CoBackgroundBlack());
        }
    }

    public IEnumerator CoBackgroundBlack()
    {
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(0.5f);
        backGround.color = Color.black;

    }
    public IEnumerator CoIsTrueStart()
    {
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(6f);
        Debug.Log(" IS TRUE START");
        isTrue = true;

    }
    public IEnumerator CoIsTrue()
    {
        // suspend execution for 0.1 seconds
        yield return new WaitForSeconds(0.5f);
        isTrue = true;

    }
    public void QuestinSpawn()
    {

        string _t = questions[Random.Range(0, questions.Length)];
        if (QuestinSpawnControl == _t)
        {
            QuestinSpawnControl = questions[Random.Range(0, questions.Length)];
        }
        else
        {
            QuestinSpawnControl = _t;
        }

        contentText.SetText(QuestinSpawnControl);

    }
    public void DeckChoice()
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
