using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            Player.GetComponent<Animator>().Play("Fly Dodge L");
        }
    }
}
