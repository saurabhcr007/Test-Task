using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5f;
    public float jumpforce = 5f;
    public bool isOnGround = true;
    private float horizontalInput;
    private float forwardInput;
    // private Rigidbody playerjump;
    // Start is called before the first frame update
    void Start()
    {
        // playerjump = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
        //     playerjump.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        //     isOnGround = false;
        // }
    }

    // private void OnCollisionEnter(Collision collision) {
    //     if(collision.gameObject.CompareTag("Ground")){
    //         isOnGround = true;
    //     }
    // }
}
