using UnityEngine;
using System.Collections;

public class MoveJoy : MonoBehaviour {
    public GameObject heart;
    Animator joyW;
    static int joyState = Animator.StringToHash("walking");
    bool walk = false;
	// Use this for initialization
	void Start () {
        joyW = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        var currentState = joyW.GetAnimatorTransitionInfo(0);
        if (isActiveAndEnabled)
        {
            if (currentState.fullPathHash > 0 || currentState.fullPathHash < 0)
            {
                walk = true;
            }
            if (walk && transform.position.z < -6)
                transform.Translate(Vector3.forward * Time.deltaTime / 5);
            else if (transform.position.z > -6)
            {
                joyW.SetBool("closeDistance", false);
                joyW.SetBool("doneWalking", true);
            }
            if (transform.position.z > -6)
            {
                heart.SetActive(true);
            }
        }
	}

}
