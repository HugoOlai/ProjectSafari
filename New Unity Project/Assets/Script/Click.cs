using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public bool carregar = false;
    // Start is called before the first frame update
    void Start()
    {
        carregar = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null )
        {
            Debug.Log("hit.collider: " + hit.collider);
            carregar = true;
        }
        else
        {

            Debug.Log("hit.collider: " + hit.collider);
            carregar = false;
        }

    }

    
}
