using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunma : MonoBehaviour
{
    public carpisma carpisma;
    public Transform transform;
     void Start()
    {
        transform = GameObject.FindGameObjectWithTag("Kova").transform;
        carpisma = transform.GetComponent<carpisma>();

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.transform.tag == "Giysi")
        {
            collision.gameObject.transform.SetParent(this.transform);
            carpisma.giysiSayaci--;
            if(carpisma.giysiSayaci <0)
            {
                carpisma.giysiSayaci = 0;
            }
            Debug.Log("Çalıntı");
        }
    }
}
