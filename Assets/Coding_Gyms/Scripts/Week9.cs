using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Week9 : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent OnTimerFinished;

    public float timerLength = 2;
    public float t;

    private void Update()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            t = 0;
        }

        // if (t < timerLength)
        //{
        //  t += Time.deltaTime;
        //}
        //else
        //{
        //   OnTimerFinished.Invoke();
        //}
    }
    public void MouseJustEntered()
    {
        Debug.Log("Mouse Just Entered Me");

        banana.localScale = Vector3.one * 1.2f;
    }
    public void MouseJustLeft()
    {
        Debug.Log("Mouse Just Left");

        banana.localScale = Vector3.one;

    }
}
