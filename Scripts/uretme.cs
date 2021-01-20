using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uretme : MonoBehaviour
{
    [SerializeField]
    private GameObject[] nesneler;
    private int sayac;
    private float rastgele;
    public float sure;
    
    void Start()
    {
        nesneler = GameObject.FindGameObjectsWithTag("Giysi");
        
        sayac = 0;
        sure = 0f;    
    }

    // Update is called once per frame
    void Update()
    {
        olustur();
        Debug.Log(rastgele + ":Kaç");
    }

   public void olustur()
    {




        rastgele = Random.Range(-11f, 11f);


        for (sayac = 0; sayac < nesneler.Length; sayac++)

            {

            sure += Time.deltaTime;


                if (nesneler[sayac].transform != null)
                {
                    
                    if(sure >=3f)
                {

                    Transform giysiler = Instantiate(nesneler[sayac].transform, new Vector3(rastgele, transform.position.y, transform.position.z), Quaternion.identity) as Transform;
                    Debug.Log(giysiler.position.y);

                    Destroy(giysiler.gameObject, 12f);
                    sure = 0f;
                }

                }

            }
        
      
    }
}
