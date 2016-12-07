using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showSponge : MonoBehaviour {
    public GameObject sponge;
    public GameObject user;
    public GameObject heart;
    Animator spongAni = null;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        sponge = GameObject.FindGameObjectWithTag("sponge");
        spongAni = sponge.GetComponent<Animator>();
        sponge.GetComponent<AudioSource>().enabled = false;
        sponge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (heart.activeSelf)
        {

            FadeText();

            var distance = Vector3.Distance(transform.position, user.transform.position);
            if (distance < 2.3)
            {
                spongAni.SetBool("laughing", true);
                sponge.GetComponent<AudioSource>().enabled = true;
            }
            else
            {
                spongAni.SetBool("laughing", false);
                sponge.GetComponent<AudioSource>().enabled = false;
            }

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
                sponge.SetActive(true);
            }

            if (Input.GetKeyDown("e"))
            {

                sponge.SetActive(false);
            }


        

    }
}
