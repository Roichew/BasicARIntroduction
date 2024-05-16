using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PartMarkerBehavior : MonoBehaviour
{
    [Header("Panel")]
    [SerializeField] public GameObject menuPanel;

    [Header("Instruction")]
    [SerializeField] public GameObject marker;
    [SerializeField] public GameObject[] instructionList;

    [Header("Header")]
    public GameObject h_Name;
    public GameObject h_Holder;

    [Header("AR Camera")]
    public Camera cam;
    Ray Rayc;

    private void Start()
    {
        
    }
    private void Update()
    {
        marker.transform.LookAt(cam.transform.position);
        Rayc = cam.ScreenPointToRay(Input.GetTouch(0).position);

        if (Physics.Raycast(Rayc, 50f))
        {
            Debug.DrawRay(Rayc.origin, Rayc.direction);
            Debug.Log("I am working");
        }

    }

    private void openPanel()
    {

    }

   
}

