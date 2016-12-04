using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showSponge : MonoBehaviour {
    public GameObject sponge;
    public GameObject user;
    Animator spongAni = null;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        sponge = GameObject.FindGameObjectWithTag("sponge");
        spongAni = sponge.GetComponent<Animator>();
        sponge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        FadeText();

        var distance = Vector3.Distance(transform.position, user.transform.position);
        if (distance < 2.3)
            spongAni.SetBool("laughing", true);
        else
            spongAni.SetBool("laughing", false);



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
            sponge.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            sponge.SetActive(false);
        }




    }
}
