using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorScript : MonoBehaviour
{
   
    public Text score;
    public int novoValor = 0;
    public GameObject Mun;
    private GameObject NovaBala;
    private GameObject NovaEspacoBala;

    //munição
    public GameObject ItemBala;
    public GameObject ItemBalaVazia;

    private List<GameObject> ListaBalas;
    private List<GameObject> ListaBalasVazia;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        ListaBalas = new List<GameObject>();
        ListaBalasVazia = new List<GameObject>();
        
        Inicio();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {           
            

            if (Mun.GetComponent<Click>().carregar)
            {
                Repositorio();
            }
            else
            {
                novoValor++;
                score.text = novoValor.ToString();
                DestoiItem();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log(bala.transform.position.x);
            Debug.Log("Pressed secondary button.");
        }
            

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }

    GameObject criaMunicao(Vector2 posicao)
    {
        GameObject NovaBala;
        NovaBala = Instantiate(ItemBala);
        NovaBala.transform.position = posicao;
        return NovaBala;
    }

    GameObject criaSlot(Vector2 posicao)
    {
        GameObject NovaBala;
        NovaBala = Instantiate(ItemBalaVazia);
        NovaBala.transform.position = posicao;
        return NovaBala;
    }

    void Inicio()
    {
        float v = 0f;
        for(int i=0; i<=5; i++)
        {
            NovaEspacoBala = criaSlot(new Vector2(ItemBalaVazia.transform.position.x + v, ItemBalaVazia.transform.position.y));
            ListaBalasVazia.Add(NovaEspacoBala);

            NovaBala = criaMunicao(new Vector2(ItemBala.transform.position.x + v, ItemBala.transform.position.y));            
            ListaBalas.Add(NovaBala);

            

            switch (i) {
                case 0:
                    NovaBala.tag = "bala0";
                break;
                
                case 1:
                    NovaBala.tag = "bala1";
                break;
                
                case 2:
                    NovaBala.tag = "bala2";
                break;
                
                case 3:
                    NovaBala.tag = "bala3";
                break;
                
                case 4:
                    NovaBala.tag = "bala4";
                break;
                
                case 5:
                    NovaBala.tag = "bala5";
                break; 
            }            

            v += 0.5f;
        }
    }

    void DestoiItem()
    {

        
        if(GameObject.FindWithTag("bala5") != null)
        {
            Destroy(GameObject.FindWithTag("bala5"));
        }
        else if (GameObject.FindWithTag("bala4") != null)
        {
            Destroy(GameObject.FindWithTag("bala4"));
        }
        else if (GameObject.FindWithTag("bala3") != null)
        {
            Destroy(GameObject.FindWithTag("bala3"));
        }
        else if (GameObject.FindWithTag("bala2") != null)
        {
            Destroy(GameObject.FindWithTag("bala2"));
        }
        else if (GameObject.FindWithTag("bala1") != null)
        {
            Destroy(GameObject.FindWithTag("bala1"));
        }
        else if (GameObject.FindWithTag("bala0") != null)
        {
            Destroy(GameObject.FindWithTag("bala0"));
        }


    }

    void Repositorio()
    {
        Destroy(GameObject.FindWithTag("bala5"));
        Destroy(GameObject.FindWithTag("bala4"));
        Destroy(GameObject.FindWithTag("bala3"));
        Destroy(GameObject.FindWithTag("bala2"));
        Destroy(GameObject.FindWithTag("bala1"));
        Destroy(GameObject.FindWithTag("bala0"));

        float v = 0f;
        
        for (int i = 0; i <= 5; i++)
        {
            NovaBala = criaMunicao(new Vector2(ItemBala.transform.position.x + v, ItemBala.transform.position.y));

            switch (i)
            {
                case 0:
                    NovaBala.tag = "bala0";
                    break;

                case 1:
                    NovaBala.tag = "bala1";
                    break;

                case 2:
                    NovaBala.tag = "bala2";
                    break;

                case 3:
                    NovaBala.tag = "bala3";
                    break;

                case 4:
                    NovaBala.tag = "bala4";
                    break;

                case 5:
                    NovaBala.tag = "bala5";
                    break;
                
            }

            v += 0.5f;

        }
    }

    void OnMouseEnter()
    {
        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseDown()
    {
        
        if (Mun.tag == "municao")
        {
            Debug.Log("HIT");
        }
        Debug.Log("clicando na munição.");
    }
}

