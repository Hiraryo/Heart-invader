using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PowerUpButton : MonoBehaviour
{
    [SerializeField] private GameObject PowerUpScreen;
    [SerializeField] private GameObject MenuScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScreenChange()
    {
        PowerUpScreen.SetActive(!PowerUpScreen.activeSelf);
        MenuScreen.SetActive(!MenuScreen.activeSelf);
    }
}
