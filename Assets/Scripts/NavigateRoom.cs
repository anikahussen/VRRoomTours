using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigateRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sign;
   // public GameObject but1;
   // public GameObject but2;

    public void ShowSign()
    {
        sign.SetActive(true);
    }
    /*
    public void ShowMenu()
    {
        but1.SetActive(true);
        but2.SetActive(true);
    }
    */
    public void HideSign()
    {
        sign.SetActive(false);
    }
    /*
    public void HideMenu()
    {
        but1.SetActive(false);
        but2.SetActive(false);
    }
    */
    void Start()
    {
        sign.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
