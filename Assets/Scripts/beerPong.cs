using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beerPong : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void HitCup()
    {
        GameObject newBall = Instantiate(ball);
        newBall.transform.position = spawnPos.position;
    }
}
