using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> bubbles;
    private float interval = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBubble", 0.0f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomBubble()
    {
        if (bubbles != null && bubbles.Count > 0)
        {
            int randomIndex = Random.Range(0, bubbles.Count-1);
            Vector3 randomPosition = new Vector3(Random.Range(-7.0f, 8.0f), -7.0f, bubbles[randomIndex].transform.position.z);
            GameObject b = Instantiate(bubbles[randomIndex], randomPosition, bubbles[randomIndex].transform.rotation);
            Debug.Log(b.GetComponent<Bubble>().Score);
        }
    }
}
