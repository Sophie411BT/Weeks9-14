using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{

    
    public TextMeshProUGUI ScoreUI;
    public int Score = 0;
    public Roach_Movment RoachMovmentScript;

    public void Start()
    {
       // if (RoachCoroutine != null)
       // {
            RoachMovmentScript.PointerClick.AddListener(AddToScore);
       // }
    }

    public void Update()
    {

    }

    public void AddToScore()
    {
        Score++;
        ScoreUI.text = Score.ToString();
    }
}
