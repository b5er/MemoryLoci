using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showBeer : MonoBehaviour {
    public GameObject beer;
    public GameObject ed;
    public GameObject user;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        beer = GameObject.FindGameObjectWithTag("beer");
        beer.SetActive(false);
        beer.GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ed.activeSelf)
        {
            var distance = Vector3.Distance(transform.position, user.transform.position);
            if (distance < 2)
            {
                beer.GetComponent<AudioSource>().enabled = true;
            }
            else
                beer.GetComponent<AudioSource>().enabled = false;
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
            beer.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            beer.SetActive(false);
        }




    }
}
