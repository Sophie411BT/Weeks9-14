using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{
    //variable for the score text (not showing Up, Fix later)
    public TextMeshProUGUI ScoreText;
   //variable for the amount score will get
    public int Amount = 0;
    //score variable
    public int Score = 0;

    //reference to win screen game object
    public GameObject WinScreen;

    

    
    private void OnEnable()
    {
        //debug.log to see if the event is acually getting triggered
        Debug.Log("Squished event working");
        Roach_Movment.Squished += AddToScore;

    }

    private void OnDisable()
    {
        Roach_Movment.Squished -= AddToScore;
    }

    private void Start()
    {
        //update the score
        UpdateScoreUI();
    }

    public void AddToScore()
    {
        //add amount to score
        Score += Amount;
        UpdateScoreUI();
    }

   

    public void UpdateScoreUI()
    {
        //if score test is = null convert scoreText to string
        if (ScoreText != null)
        {
            ScoreText.text = $"Score: {Score}";
        }
        //if teh score is greater or = to 2 set the win screen to active in the inspector
        if (Score >= 2)
        {

            WinScreen.SetActive(true);
            //debug.log to check if the
            Debug.Log("Yay");
            
        }
    }

   
}
