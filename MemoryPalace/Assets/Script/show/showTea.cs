using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showTea : MonoBehaviour {
    public GameObject tea;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        tea = GameObject.FindGameObjectWithTag("tea");
        tea.SetActive(false);
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
            tea.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            tea.SetActive(false);
        }




    }
}
