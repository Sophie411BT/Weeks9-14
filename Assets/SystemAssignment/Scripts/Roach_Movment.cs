using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roach_Movment : MonoBehaviour
{
    public float moveTime = 3f;
    public Vector2 startPos; 
    public Vector2 endPos;
    public AnimationCurve curve;


    private void Start()
    {
        StartCoroutine(RoachMove(transform.position, endPos));
    }

    IEnumerator RoachMove(Vector2 startPos, Vector2 endPos)
    {

        
        float timeElapsed = 0f;
        

        //A while loop that tells the code to smear the sprite movment across several frames for a duration of 3
        while (timeElapsed < moveTime)
        {
          
            //a float called curveTime that uses time elapsed to see how far into the coroutine we are
            float curveTime = timeElapsed / moveTime;
            //
            float curveVal = curve.Evaluate(curveTime);


        }

        transform.position = endPos;

        yield return null;

        } 
   
}

    

