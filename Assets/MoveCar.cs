using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    private float xMove;
    // Start is called before the first frame update
    void Start()
    {
        xMove = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        xMove = xMove - (10.0f * Time.deltaTime);
        //transform.Translate(4.0f, 1.5f, -10.0f);
        transform.position = new Vector3(xMove, 1.5f, -10.0f);         
    }
}
