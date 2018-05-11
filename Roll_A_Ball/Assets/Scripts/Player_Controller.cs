using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    // Public Variables
    // Accessible by Unity Script Component
    public float speed; 
    public Text playerHUD;
    public Text winText;

    // Private Variables
    private int count;
    private Rigidbody rb;               // Access to rigidbody component to move object

    // Start
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the rigidbody component
        count = 0;                      // Initialize count to zero
        setCountText();                 // Set the count text on the player HUD
    }

    // 
    void FixedUpdate()
    {  //  Called just before physics calc
       // Physics code
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement*speed);
    }

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.CompareTag("collectible"))
			{
				collider.gameObject.SetActive(false);
                count++;
                setCountText();
            if (count == 12)
                winText.text = "You Win!";
                    
			}
	}

    void setCountText()
    {
        playerHUD.text = "Score: " + count.ToString();
    }
}
