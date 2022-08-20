using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject player;
    public GameObject Enemy;
    public TextMeshProUGUI guiText;

    //Image image;

    [SerializeField]
    float range = 2.8f;
    private bool CanvasEnable = false;

    void Start()
    {
        float health = Enemy.GetComponent<Target>().health;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        transform.GetComponent<Image>().enabled = distance <= range;

        if(transform.GetComponent<Image>().enabled == false)
        {
            text.enabled = false;
            CanvasEnable = false;
        }
        else
        {
            text.enabled = true;
            CanvasEnable = true;
        }
        
        if(Input.GetKey("e"))
        {
            if(CanvasEnable)
            {
                if(Enemy.transform.GetComponent<Renderer>().enabled == true)
                {
                    Enemy.GetComponent<Target>().health = 50f;
                    guiText.text = "Dummy's health: " + 50;
                }
                else if(Enemy.transform.GetComponent<Renderer>().enabled == false)
                {
                    guiText.enabled = true;
                    Enemy.transform.GetComponent<Renderer>().enabled = true;
                }
            }
        }
    }
}
