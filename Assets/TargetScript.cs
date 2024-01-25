using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public LogicScript logicScript;
    public int value = 1;
    public int hp = 1;


    public void gotHit()
    {
        this.hp--;
        if(hp == 0) 
        {
            logicScript.addScore(value);
            this.kys();
        }
    }
    public void kys()
    {
        //...
        Destroy(gameObject);
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
        Debug.Log("TARGET: Collide");
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Projectile") {
            this.gotHit();
        }
    }
}
