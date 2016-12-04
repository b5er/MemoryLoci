using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showJoy : MonoBehaviour {
    Animator joyW = null;
    public GameObject joy;
    public GameObject user;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        joy = GameObject.FindGameObjectWithTag("joy");
        joyW = joy.GetComponent<Animator>();
        joy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        FadeText();

        var distance = Vector3.Distance(transform.position, user.transform.position);
        if (distance < 2.3)
            joyW.SetBool("closeDistance", true);
        else
            joyW.SetBool("closeDistance", false);

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
            joy.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            joy.SetActive(false);
        }




    }
}
