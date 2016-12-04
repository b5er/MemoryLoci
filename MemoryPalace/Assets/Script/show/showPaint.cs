using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showPaint : MonoBehaviour {

    public GameObject paint;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        paint = GameObject.FindGameObjectWithTag("bach");
        paint.SetActive(false);
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
            paint.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            paint.SetActive(false);
        }




    }




}
