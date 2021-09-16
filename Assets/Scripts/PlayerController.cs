using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    new public Transform transform;
    private int collectedObjects = 0;

    private bool goUp = false;
    private bool goDown = false;
    private bool goLeft = false;
    private bool goRight = false;

    private bool collectEnabled = false;
    private GameObject collectedGameObject;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 300;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movementHandler();

    }
    void Update() {
        collect();
        movementInput();
    }
   
    private void movementInput() {
        if (Input.GetKey("up"))
        {
            goUp = true;
        }
        else {
            goUp = false;
        }
        if (Input.GetKey("left"))
        {
            goLeft = true;
        }
        else
        {
            goLeft = false;
        }
        if (Input.GetKey("right"))
        {
            goRight = true;
        }
        else
        {
            goRight = false;
        }
        if (Input.GetKey("down"))
        {
            goDown = true;
        }
        else
        {
            goDown = false;
        }
    }
    private void movementHandler() {

        if (goUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.1f);

        }
        if (goLeft)
        {
            transform.position = new Vector2(transform.position.x - 0.1f, transform.position.y);

        }

        if (goRight)
        {
            transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);

        }
        if (goDown)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.1f);

        }
    }

    private void collect() {
        if (Input.GetKeyDown(KeyCode.E)&& collectEnabled){


            collectedObjects++;
        Debug.Log(collectedObjects);
        Destroy(collectedGameObject);
        }
    }

    public void setCollectEnabled(bool b) {

        collectEnabled = b;
    }

    public int getCollectedGameObject() {

        return collectedObjects;
    }

    public void setCollectedGameObject(GameObject g) {

    collectedGameObject =  g;
}
}
