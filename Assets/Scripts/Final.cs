using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Final : MonoBehaviour
{
    public GameObject score;
    private TextMeshProUGUI scoreText;

    int scoreHolder;
    void Start()
    {
        scoreText = score.GetComponent<TextMeshProUGUI>();
        scoreHolder = PlayerPrefs.GetInt("GameScore");
        scoreText.SetText(scoreHolder.ToString());
    }
}
