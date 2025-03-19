using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public float timeAnHourTakes = 5;
    public Transform minuteHand;
    public Transform hourHand;

    public float t;
    public int hour = 0;

    public UnityEvent<int>OnTheHour;

    //a variable to tell the code the clock is running
    Coroutine clockIsRunning;
    IEnumerator doingOneHourOfMovment;

    void Start()
    {
        //assign clockIsRunning so that we can stop it from running 
        clockIsRunning = StartCoroutine(MoveTheClock());
    }
    //wrap a coroutine in another coroutine and don't forget the yield stment
    IEnumerator MoveTheClock()
    {
        while (true)
        {
            doingOneHourOfMovment = MoveTheClockHandOneHour();
            yield return StartCoroutine(MoveTheClockHandOneHour());
        }
        
        
    }
        

    IEnumerator MoveTheClockHandOneHour()
    {
        while(t < timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        hour++;
        if(hour == 13)
        {
            hour = 1;
        }

        //give it an int or it will be mad because onHourHand is assigned int
        OnTheHour.Invoke(hour);
    }

    public void StopTheClock()
    {
        StopCoroutine(MoveTheClock());
        StopCoroutine(doingOneHourOfMovment);
    }
}
