using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showEd : MonoBehaviour {


    public GameObject figure;
    public GameObject door;
    public Text myText;
    public float fadeTime;
    public bool display;
    

    // Use this for initialization
    void Start()
    {

        figure = GameObject.FindGameObjectWithTag("Ed");
        figure.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (door.activeSelf)
        {
            FadeText();
        }
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
            figure.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            figure.SetActive(false);
        }




    }


}
