using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE: inheriting basics from the Bubble class and implementing a special Move method
public class BubbleSideways : Bubble
{
    private float initialX;
    private float xRange = 1.0f;
    private bool movingLeft;

    void Awake()
    {
        score = 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        initialX = transform.position.x;
        movingLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyIfOutOfBounds();
    }

    // POLYMORPHISM: overriding the Move method for special behaviour for this class
    public override void Move()
    {
        float x = transform.position.x;
        if (movingLeft)
            x -= speed * Time.deltaTime;
        else
            x += speed * Time.deltaTime;
        
        transform.position = new Vector3(x, transform.position.y + speed * Time.deltaTime, transform.position.z);

        CheckDirection();
    }

    // ABSTRACTION: abstracted this out of the Move method
    private void CheckDirection()
    {
        if (movingLeft)
        {
            if (transform.position.x < initialX - xRange)
                movingLeft = false;
        }
        else if (transform.position.x > initialX + xRange)
            movingLeft = true;
    }
}
