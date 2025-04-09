using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Roach_Movment : MonoBehaviour
{
    public UnityEvent PointerClick;
    public float moveTime = 4f;
    public Vector2 startPos;
    public Vector2 endPos;
    public AnimationCurve curve;
    public float timeElapsed;

    public Image image;

    public Sprite Alive;
    public Sprite Dead;

    private RectTransform rect;

    public Coroutine RoachCoroutine;

    public void Start()
    {

        rect = GetComponent<RectTransform>();
        //start the coroutine going from current position to endPos
        RoachCoroutine = StartCoroutine(RoachMove(transform.position, endPos));

        //Add a listener so that the score scripts can track when the coroutine ends
        PointerClick.AddListener(Squished);

    }

    //A coroutine that usses lerp to move the sprite fron startPos to endPos, and back in a loop
    IEnumerator RoachMove(Vector2 startPos, Vector2 endPos)
    {

        //set time elapsed to 0 to start
        float timeElapsed = 0f;


        //A while loop that tells the code to smear the sprite movment across several frames for a duration of 3
        while (timeElapsed < moveTime)
        {

            //a float called curveTime that uses time elapsed to see how far into the coroutine we are
            float curveTime = timeElapsed / moveTime;

            //
            float curveVal = curve.Evaluate(curveTime);

            //make time elapsed inscrease as time gets bigger
            timeElapsed += Time.deltaTime;

            //use lerp to interpolate current val between start and end positions
            Vector2 currentPos = Vector2.Lerp(startPos, endPos, curveVal);

            //set the transform position to the current position so that the sprite follows the curve
            rect.position = currentPos;


           
           

          
            //yeild at the end of the coroutine
            yield return null;
        }
        //restart the coroutine using start pos instead of end pos so the the sprite move sin the other direction
        StartCoroutine(RoachMove(transform.position, startPos));

    }

   
       
        public void Squished()
    {
        if (RoachCoroutine != null)
        {
            StopAllCoroutines();
            RoachCoroutine = null;
            Debug.Log("squished");
            image.sprite = Dead;  
            
            
        }
    }

}

    

