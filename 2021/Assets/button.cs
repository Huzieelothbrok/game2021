using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         fun();
        
    }
   public void fun()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float middle = Screen.height / 2;
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.y > middle)
                {
                    transform.Translate(new Vector3(0, 10f, 0));
                }
                else if (touch.position.y < middle)
                {
                    transform.Translate(new Vector3(0, -10f, 0));
                }
            }
        }
    }
}
