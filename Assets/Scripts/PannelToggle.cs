using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelToggle : MonoBehaviour
{
    [SerializeField] public Animator panelAnim;
    public Animation openAnim;
    public Animation closeAnim;
    public bool isOpen;
    void Start()
    {
        panelAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            openAnim.Play();
        }
        else
        {
            closeAnim.Play();
        }
    }
}
