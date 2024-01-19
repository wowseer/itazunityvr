using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGrabbable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         gameObject.AddComponent<Rigidbody>();
         gameObject.AddComponent<BoxCollider>();
        
    }

    // Update is called once per frame
}
