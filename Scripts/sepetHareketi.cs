using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sepetHareketi : MonoBehaviour
{

   

    // Update is called once per frame
    void Update()
    {
        float xEkseni = Input.GetAxisRaw("Horizontal") * 2f;
        float kisitlama = Mathf.Clamp(xEkseni, -11f,11f);
        transform.position = new Vector3(5*kisitlama, transform.position.y, transform.position.z);
    }
       
}
