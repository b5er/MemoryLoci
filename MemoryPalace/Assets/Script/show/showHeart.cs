using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showHeart : MonoBehaviour {
    public GameObject heart;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        heart = GameObject.FindGameObjectWithTag("heart");
        heart.SetActive(false);
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



        if (Input.GetKeyDown("e"))
        {

            heart.SetActive(false);
        }




    }
}
