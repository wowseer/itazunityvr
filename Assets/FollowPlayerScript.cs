using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public float distanceToKeep = 1f;
    public float sensoryRange = 5f;
    public float speed = 1f;
    public GameObject playerReference;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        Debug.Log(playerReference.transform.position);
        if ((playerReference.transform.position - transform.position).magnitude > distanceToKeep)
        {move(playerReference.transform.position);}
    }

    private void move(Vector3 targetPosition) 
    {
        Vector3 distance = targetPosition - transform.position;
        Vector3 direction = Vector3.Normalize(distance);
        float stepLenght = speed * Time.deltaTime;
        transform.position += direction * stepLenght;
    }

}
