using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketlenme : MonoBehaviour
{
    [SerializeField]
    private Vector3 sag;
    private Vector3 sol;
    private Transform nesne;
    private SpriteRenderer sprite;
    private bool sagaSola;
    void Start()
    {
        nesne = GameObject.FindGameObjectWithTag("Arkaplan").transform;
        sprite = nesne.GetComponent<SpriteRenderer>();
        sag = new Vector3(sprite.bounds.size.x, transform.position.y, transform.position.z);
        sol = new Vector3(-sprite.bounds.size.x, transform.position.y, transform.position.z);
        sagaSola = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(sagaSola)
        {
            sprite.flipX = true;
            transform.position = Vector3.MoveTowards(transform.position, sol, 3f * Time.deltaTime);
            if(transform.position.x <= -10f)
            {
                sagaSola = false;

            }
           
        }
        else
        {
            sprite.flipX = false;
            transform.position = Vector3.MoveTowards(transform.position, sag, 3f * Time.deltaTime);
            if(transform.position.x >= 10f)
            {
                sagaSola = true;
            }
            
        }

    }
}
