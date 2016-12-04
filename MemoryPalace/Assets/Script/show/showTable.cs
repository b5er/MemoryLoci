using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showTable : MonoBehaviour {
    public GameObject table;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        table = GameObject.FindGameObjectWithTag("table");
        table.SetActive(false);
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
            table.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            table.SetActive(false);
        }




    }
}
