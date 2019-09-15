using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool printed;

    // Start is called before the first frame update
    void Start()
    {
        printed = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3 && printed) {
            print ("It's been 3 seconds!");
            printed = false;
        }
    }
}
