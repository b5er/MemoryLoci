using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showSquid : MonoBehaviour {
    public GameObject squid;
    public GameObject sponge;
    public GameObject heart;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {
        squid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (heart.activeSelf)
        {
            FadeText();
            if (sponge.GetComponent<Animator>().GetBool("laughing"))
            {
                squid.GetComponent<Animator>().SetBool("shakingHead", true);
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
            squid.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            squid.SetActive(false);
        }




    }
}
