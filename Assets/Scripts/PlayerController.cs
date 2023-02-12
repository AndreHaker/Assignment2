using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int speed1 = 10;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private int count;
    public GameObject winTextObject;
    public GameObject player;

    
    private int color = 0;
    private int size = 0;
    private int speed = 0;


    Renderer meshRenderer;
    private Vector3 scalechange;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player.GetComponent<Transform>();
        
        meshRenderer = GetComponent<Renderer>();
        SetCountText();
        winTextObject.SetActive(false);
        color = DropDownColor.color;
        speed = DropDownSpeed.speed;
        size = DropDownSize.size;
        
        

        if (color == 0)
        {
            meshRenderer.GetComponent<Renderer>().material.color = Color.blue;
               
        }
        else if (color == 1)
        {
            meshRenderer.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (color == 2)
        {
            meshRenderer.GetComponent<Renderer>().material.color = Color.green;
        }

        if (speed == 0)
        {
            speed1 = 5;

        }
        else if (speed == 1)
        {
            speed1 = 10;
        }
        else if (speed == 2)
        {
            speed1 = 20;
        }

        if (size == 0)
        {
            scalechange = new Vector3(0.5f, 0.5f, 0.5f);
            player.GetComponent<Transform>().localScale = scalechange;
        } 
        else if (size == 1)
        {
            scalechange = new Vector3(1.5f, 1.5f, 1.5f);
            player.GetComponent<Transform>().localScale = scalechange;
        }
        else if (size == 2)
        {
            scalechange = new Vector3(2f, 2f, 2f);
            player.GetComponent<Transform>().localScale = scalechange;
        }
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winTextObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count +1;
            SetCountText();
        }
        
    }

   

    
}

