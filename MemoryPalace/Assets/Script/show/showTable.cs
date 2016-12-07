using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showTable : MonoBehaviour {
    public GameObject table;
    public GameObject ed;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        table = GameObject.FindGameObjectWithTag("table");
        table.SetActive(false);
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
            table.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            table.SetActive(false);
        }




    }
}
