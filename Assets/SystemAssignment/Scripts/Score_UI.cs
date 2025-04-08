using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{
    public Text  ScoreUI;
    public int Score = 0;
    public 
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreUI();
    }

   private void SpriteClicked()
    {
        //Listen for teh sprite to be clicked in coroutine
    }

    private void UpdateScoreUI()
    {
        ScoreUI.text = "Score: " + Score; ///
    }
}
