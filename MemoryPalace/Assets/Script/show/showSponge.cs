using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showSponge : MonoBehaviour {
    public GameObject sponge;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        sponge = GameObject.FindGameObjectWithTag("sponge");
        sponge.SetActive(false);
        myText.color = Color.clear;
        //Screen.showCursor = false;
        //Screen.lockCursor = true;
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
            sponge.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            sponge.SetActive(false);
        }




    }
}
