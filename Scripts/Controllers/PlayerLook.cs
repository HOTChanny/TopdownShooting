using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    Transform tf;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tf = transform;
        Vector2 mousePos = Input.mousePosition;

        Vector3 target = Camera.main.ScreenToWorldPoint(mousePos);

        if (target.x < tf.position.x)
        {
            tf.localScale = new Vector3(-3, 3, 3);
        }
        else
        {
            tf.localScale = new Vector3(3, 3, 3);
        }
    }
}
