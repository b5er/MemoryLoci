using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class joyStand : MonoBehaviour {
    public GameObject jStand;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        jStand = GameObject.FindGameObjectWithTag("joyStand");
        jStand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        FadeText();

        /*if (Input.GetKeyDown (KeyCode.Escape)) 
         
                {
                        Screen.lockCursor = false;
                         
                }
                */


    }

    void OnMouseOver()
    {
        display = true;

    }



    void OnMouseExit()

    {
        display = false;

    }


    void FadeText()

    {


        if (display)
        {
            jStand.SetActive(true);
        }

        if(Input.GetKeyDown("e"))
        {

            jStand.SetActive(false);
        }




    }
}
