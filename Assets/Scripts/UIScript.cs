using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] GameObject infoUIPanel;

    private void OnEnable()
    {
        EventManager.showPlanetInfoUI += showPlanetInfoUI;
    }

    private void OnDisable()
    {
        EventManager.showPlanetInfoUI -= showPlanetInfoUI;
    }

    void Start()
    {
        infoUIPanel.SetActive(false);
    }
    
    void Update()
    {
        
    }

    public void closeInfoUI()
    {
        infoUIPanel.SetActive(false);
    }

    private void showPlanetInfoUI()
    {
        infoUIPanel.SetActive(true);
    }
}
