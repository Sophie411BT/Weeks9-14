using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week11CodingGym : MonoBehaviour
{
    AudioSource footstep;
 

    private void Start()
    {
        footstep = GetComponent<AudioSource>();
        Debug.Log("Sound is Playing");
     
    }

    private void Update()
    {
        
    }
}
