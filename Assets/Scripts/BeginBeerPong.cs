using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginBeerPong : MonoBehaviour
{
    public beerPong bp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Col with: " + other.gameObject.name);
        bp.HitCup();
    }
}
