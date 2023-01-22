using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Touch touch;
    private float speed;
    private float forwardHizi;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        forwardHizi = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(transform.forward * Time.deltaTime * forwardHizi);
      if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x +
                    touch.deltaPosition.x * speed * Time.deltaTime, transform.position.y,
                    transform.position.z);
            }
        }
    }
    
}
