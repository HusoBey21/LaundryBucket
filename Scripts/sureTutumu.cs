using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sureTutumu : MonoBehaviour
{

    public int dakika;
    public int saniye;
    public float zaman;
    public Text metin;
    void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Süre").GetComponent<Text>();
        zaman = 420f;
        

    }
    
    void Update()
    {
        geriSayim();
    }

    public void geriSayim()
    {

        zaman-= Time.deltaTime;
        dakika = Mathf.FloorToInt(zaman / 60f);
        saniye = Mathf.FloorToInt(zaman % 60f);
        metin.text = "Time :" + string.Format("{0}:{1}", dakika.ToString(), saniye.ToString());
        if(saniye <10)
        {
            metin.text = "Time :" + dakika.ToString() + ":" + "0" + saniye.ToString();

        }
        if(dakika ==0 && saniye==0)
        {
            SceneManager.LoadScene(0);
        }
       
    }
    public void bastanBasla()
    {
        SceneManager.LoadScene(0);
    }
}

