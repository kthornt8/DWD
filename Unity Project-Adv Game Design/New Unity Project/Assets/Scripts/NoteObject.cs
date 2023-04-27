using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public bool obtained = false;
    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(keyToPress))
       {
           if(canBePressed)
           {
               obtained = true;
               gameObject.SetActive(false);
               //GameManager.instance.NoteHit();

               if(Mathf.Abs(transform.position.y) > 0.25)
               {
                   Debug.Log("Hit!");
                   GameManager.instance.NormalHit();
                   Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
               }
               else if (Mathf.Abs(transform.position.y) > 0.05f)
               {
                   Debug.Log("Good!");
                   GameManager.instance.GoodHit();
                   Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
               }
               else
               {
                   Debug.Log("Perfect!");
                   GameManager.instance.PerfectHit();
                   Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
               }
           }
       } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Activator" )
        {
            canBePressed = true;
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Activator" )
        {
            canBePressed = false;
        } 
        //if (collision.tag == "Activator" && gameObject.activeSelf){GameManager.instance.NoteMiss();}
        if(!obtained)
        {
            GameManager.instance.NoteMiss();
            Instantiate(missEffect, transform.position, missEffect.transform.rotation);
        }
       // else
        //{
            //GameManager.instance.NoteHit();
        //}
    }
}
