using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR; //for makingthe buttons appear.
    public Sprite defaultImage; //pulls up the default image. 
    public Sprite pressedImage;//pulls up the pressed image.
    public KeyCode keyToPress; //determines what key is pressed.

    // Start is called before the first frame update (used for initialization)
    void Start()
    {
       theSR = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
        }
        if(Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage;
        }
    }
}
