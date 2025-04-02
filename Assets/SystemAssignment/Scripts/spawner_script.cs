using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class spawner_script : MonoBehaviour
{
    public float Score;
    public float NumOfCircles = 5f;
    public GameObject Circles;
    public float CirclePos;
    public bool gameStarted = true;

    // Start is called before the first frame update
    void Start()
    {
       
        while (gameStarted == true)
        { 

        GameObject gameObject = Instantiate(Circles, Random.insideUnitCircle * 6, transform.rotation);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
