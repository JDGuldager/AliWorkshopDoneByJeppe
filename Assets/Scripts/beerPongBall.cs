using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beerPongBall : MonoBehaviour
{
    GameObject bpSpawner;
    // Start is called before the first frame update
    void Start()
    {
        bpSpawner = GameObject.Find("Ball spawn point 1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void killAfterTime()
    {
        Destroy(gameObject, 5);
        StartCoroutine(passiveMe(2));
    }
    
IEnumerator passiveMe(int secs)
    {
        yield return new WaitForSeconds(secs);
        bpSpawner.GetComponent<beerPong>().HitCup();
    }
    private void OnTriggerEnter(Collider target)
    {
        Debug.Log("Collided with: " );
        if (target.tag == "Cup")
        {
            Destroy(target.transform.parent.gameObject);
            Destroy(gameObject);
            bpSpawner.GetComponent<beerPong>().HitCup();
        }
    }
}
