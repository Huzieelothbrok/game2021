using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchdragmovement : MonoBehaviour
{
    private Touch touch;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position=new Vector3(transform.position.x + touch.deltaPosition.x * speed,
                transform.position.y+touch.deltaPosition.y*speed,
                transform.position.z);
            }
        }
    }
}
