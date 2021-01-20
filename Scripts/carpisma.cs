using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpisma : MonoBehaviour
{
    public Transform cocuk;
    public Text metin;
    public int giysiSayaci;
    void Start()
    {
        cocuk = this.transform.GetChild(0);
        metin = GameObject.FindGameObjectWithTag("Sayı").GetComponent<Text>();
        giysiSayaci = 0;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Giysi"))
        {
            collision.gameObject.transform.SetParent(this.transform);
            collision.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            collision.gameObject.transform.position = cocuk.position;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), 3f * Time.deltaTime);
            giysiSayaci += 1;
            Debug.Log("Vurulduk");
        }
    }

    void Update()
    {
        metin.text = "Clothes:" + giysiSayaci.ToString();
    }
}
