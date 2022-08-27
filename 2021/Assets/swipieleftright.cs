using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipieleftright : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SwipeManager.swipeRight)
        {
            transform.Translate(new Vector3(10f, 0, 0));
        }
        else if (SwipeManager.swipeLeft)
        {
            transform.Translate(new Vector3(-10f, 0, 0));
        }
        else if (SwipeManager.swipeUp)
        {
            transform.Translate(new Vector3(0, 10f, 0));
        }
        else if (SwipeManager.swipeDown)
        {
            transform.Translate(new Vector3(0, -10f, 0));
        }
    }
}
