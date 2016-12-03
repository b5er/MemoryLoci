using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showSquid : MonoBehaviour {
    public GameObject squid;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        squid = GameObject.FindGameObjectWithTag("squid");
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
            squid.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            squid.SetActive(false);
        }




    }
}
