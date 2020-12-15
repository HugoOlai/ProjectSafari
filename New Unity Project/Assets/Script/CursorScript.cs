using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorScript : MonoBehaviour
{
   
    public Text score;
    public int novoValor = 0;

    //munição
    public GameObject ItemBala;
   

    public GameObject[] ListaBalas;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i < 5; i++)
        {
            ListaBalas[i] = (GameObject)Instantiate(ItemBala, new Vector2(ItemBala.transform.position.x +i,
                ItemBala.transform.position.y), Quaternion.identity);
        }



        if (Input.GetMouseButtonDown(0))
        {
            novoValor++;
            score.text = novoValor.ToString();
        }

        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log(bala.transform.position.x);
            Debug.Log("Pressed secondary button.");
        }
            

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
}

