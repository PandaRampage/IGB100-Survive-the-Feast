using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomKey : MonoBehaviour
{
    public Inventory inv;
    public GameObject notice;
    public GameObject Door;
    public GameObject image;
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider collision)
    {
        if(collision.GetComponent<Move>())
        {
            notice.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                inv.Get1();
                Destroy(gameObject);
                Destroy(Door.gameObject);
                notice.SetActive(false);
                image.SetActive(true);
                timer.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Move>())
        {      
            notice.SetActive(false);
        }  
    }
}
