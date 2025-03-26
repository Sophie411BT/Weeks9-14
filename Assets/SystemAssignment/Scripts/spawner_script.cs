using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class spawner_script : MonoBehaviour
{
    public float Score;
    public float NumOfRoaches;
    public GameObject Roach;
    public float roachPos;

    // Start is called before the first frame update
    void Start()
    {
        roachPos = Random.Range(-12, 12);
        Instantiate(Roach);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
