using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showBeer : MonoBehaviour {
    public GameObject beer;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        beer = GameObject.FindGameObjectWithTag("beer");
        beer.SetActive(false);
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
            beer.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            beer.SetActive(false);
        }




    }
}
