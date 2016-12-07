using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showPaint : MonoBehaviour {

    public GameObject paint;
    public GameObject door;
    public GameObject user;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        paint = GameObject.FindGameObjectWithTag("bach");
        paint.SetActive(false);
        paint.GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (door.activeSelf) { 

            var distance = Vector3.Distance(transform.position, user.transform.position);
            if(distance < 3.5)
            {
                paint.GetComponent<AudioSource>().enabled = true;
            } else
            {
                paint.GetComponent<AudioSource>().enabled = false;
            }
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
            paint.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            paint.SetActive(false);
        }




    }




}
