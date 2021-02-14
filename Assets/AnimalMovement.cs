using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count > 1000)
        {
            count = 0;
        }
        var Vec = transform.localPosition;  
        Vec.x += count > 500 ? .01f : -.01f;
        //Vec.y += count > 400 ? .2f : -.2f;
        transform.localPosition = Vec;  
        

    }
}
