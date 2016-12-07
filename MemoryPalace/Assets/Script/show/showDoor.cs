using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showDoor : MonoBehaviour {
    public GameObject door;
    public GameObject heart;
    public Text myText;
    public float fadeTime;
    public bool display;


    // Use this for initialization
    void Start()
    {

        door = GameObject.FindGameObjectWithTag("door");
        door.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (heart.activeSelf)
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
            door.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {

            door.SetActive(false);
        }




    }
}
