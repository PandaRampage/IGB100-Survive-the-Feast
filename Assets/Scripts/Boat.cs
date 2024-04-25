using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public Inventory inv;
    public GameObject noticeEs;
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
            if(inv.item3 == true)
            {
                noticeEs.SetActive(true);
                if(Input.GetKey(KeyCode.Mouse0))
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                }
            }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Move>())
        {      
            noticeEs.SetActive(false);
        }  
    }
}
