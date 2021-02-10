using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotation : MonoBehaviour
{ 

    public KeyCode pressW;
    public KeyCode pressA;
    public KeyCode pressS;
    public KeyCode pressD;

    private int rotationVelocity = 50;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(Input.GetKeyDown(pressW))
            GetComponent<Transform>().Rotate(Vector3.up * Time.deltaTime * rotationVelocity);

        while (Input.GetKeyDown(pressA))
            GetComponent<Transform>().Rotate(Vector3.left * Time.deltaTime * rotationVelocity);

        while (Input.GetKeyDown(pressS))
            GetComponent<Transform>().Rotate(Vector3.down * Time.deltaTime * rotationVelocity);

        while (Input.GetKeyDown(pressD))
            GetComponent<Transform>().Rotate(Vector3.right * Time.deltaTime * rotationVelocity);

    }
}
