using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public int amount = 1;

    void consume(int n)
    {
        if(n >= amount) {Destroy(gameObject);}
        else {amount -= n;}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Weapon") {
            Debug.Log("Stompin on da dakka");
        }

    }


}
