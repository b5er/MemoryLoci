using UnityEngine;
using System.Collections;

public class triggered : MonoBehaviour {
    Animator joyH;
    public GameObject joy;
	// Use this for initialization
	void Start () {
        joyH = joy.GetComponent<Animator>();
	}

    private void Update()
    {
        OnTriggerEnter(GetComponent<BoxCollider>());
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (joy.transform.position.z > -6)
        {
            joyH.SetBool("atTable", true);
        }
    } 
}
