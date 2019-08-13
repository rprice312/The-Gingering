
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody playerRB;

    // Player control forces
    public float fwdForce = 1000f;
    public float sideForce = 100f;
    public float torqueForce = 50f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Level 1 Begin!");
        playerRB.AddForce(0,0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRB.AddForce(0, 0, fwdForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            playerRB.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }
        if (Input.GetKey("a") )
        {
            playerRB.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);    
        }
        
        if (Input.GetKey("q") )
        {
            playerRB.AddTorque(0, 0, torqueForce * Time.deltaTime, ForceMode.Impulse);
        }
        
        if (Input.GetKey("e") )
        {
            playerRB.AddTorque(0, 0, -torqueForce * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
