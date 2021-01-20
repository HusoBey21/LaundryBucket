using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asagiyaDogru : MonoBehaviour
{
  
    
    void Update()
    {
        float a = Mathf.Clamp(transform.position.y, -14f, transform.position.y);
        transform.position = new Vector3(transform.position.x, a, transform.position.z);
        transform.position += Vector3.down * 1f * Time.deltaTime;
       
        
    }
}
