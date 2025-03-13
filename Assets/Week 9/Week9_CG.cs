using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Codimg_Gym : MonoBehaviour
{
    public Image image;

    public Sprite Highlight;
    public Sprite normal;

    public TextMeshProUGUI reactionText;

    public void Start()
    {
        reactionText.text = "yumy";
    }
    public void MouseIsOverUs()
    {
        image.sprite = Highlight;
        reactionText.text = "mmmm!";
    }

    public void MouseNotOverUs()
    {
        image.sprite = normal;
        reactionText.text = "Yumy";
    }
}
