using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    protected float speed = 2.0f;

    // ENCAPSULATION: protecting score from being manipulated from outside the class
    protected int score;
    public int Score
    {
        get { return score; }
        private set { score = value; }
    }

    void Awake()
    {
        score = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyIfOutOfBounds();
    }

    public virtual void Move()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
    }

    protected void DestroyIfOutOfBounds()
    {
        if (transform.position.y > 8.0f)
            Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
