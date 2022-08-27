using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlmovem : MonoBehaviour
{
    private float touchspeed = 0.000001f;
    Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * touchspeed, transform.position.y, transform.position.z + touch.deltaPosition.y * touchspeed);
            }
        }
    }
}
