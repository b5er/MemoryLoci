using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showDoor : MonoBehaviour {
    public GameObject door;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        door = GameObject.FindGameObjectWithTag("door");
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
            door.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            door.SetActive(false);
        }




    }
}
