using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showTea : MonoBehaviour {
    public GameObject tea;
    public GameObject ed;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        tea = GameObject.FindGameObjectWithTag("tea");
        tea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (ed.activeSelf)
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
            tea.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            tea.SetActive(false);
        }




    }
}
