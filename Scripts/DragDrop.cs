using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    // I wanna be able to move an object If I clicked on It

    bool canMove;
    bool canDrag;
    GameObject turner;
    Vector3 objectPos;

    Collider2D collider;

    private void Start()
    {
        collider = GetComponent<Collider2D>();
        turner = collider.gameObject;
        objectPos = this.transform.position;
        canMove = false;
        canDrag = false;
    }

    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
                Instantiate(turner, turner.transform.position, new Quaternion(0,0,0,0));
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                canDrag = true;
            }
        }
        // Deleting object
        if (Input.GetMouseButtonDown(1))
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                Destroy(collider.gameObject);
            }
        }

        if (canDrag)
        {
            objectPos = mousePos;
            objectPos.z = 10f;
            this.transform.position = objectPos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            canDrag = false;
            canMove = false;
        }
    }
}
