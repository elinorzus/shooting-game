using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]

public class EscButton : MonoBehaviour
{
    public GameObject player;
    public GameObject gun;
    public Camera main;
    public Canvas canvas;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    //public Button ResumeButton;

    // Start is called before the first frame update
    void Start()
    {
        canvas.GetComponent<Transform>().Find("ResumeButton").GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    bool pressed = false;

    void Update()
    {
        var panel = canvas.GetComponent<Transform>().Find("Panel");

        var ResumeButton = canvas.GetComponent<Transform>().Find("ResumeButton");
        var ResumeButtonText = canvas.GetComponent<Transform>().Find("ResumeButtonText");

        var ExitButton = canvas.GetComponent<Transform>().Find("ExitButton");
        var ExitButtonText = canvas.GetComponent<Transform>().Find("ExitButtonText");

        if (Input.GetKey(KeyCode.Q))
        {
            Cursor.lockState = CursorLockMode.None;
            //ResumeButton.GetComponent<ContinueScript>().pressed = true;
            ResumeButton.GetComponent<Image>().enabled = true;
            text1.enabled = true;
            panel.GetComponent<Image>().enabled = true;

            ExitButton.GetComponent<Image>().enabled = true;
            text2.enabled = true;

            pressed = true;
        }

        if(pressed == false)
        {
            panel.GetComponent<Image>().enabled = false;
            ExitButton.GetComponent<Image>().enabled = false;
            text2.enabled = false;
            text1.enabled = false;
            ResumeButton.GetComponent<Image>().enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<Movment>().enabled = true;
            main.transform.GetComponent<MouseLook>().enabled = true;
            gun.GetComponent<GunShooting>().enabled = true;
        }
        else
        {
            player.GetComponent<Movment>().enabled = false;
            main.transform.GetComponent<MouseLook>().enabled = false;
            gun.GetComponent<GunShooting>().enabled = false;
        }

    }

    public void OnClick()
    {
        pressed = false;
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
