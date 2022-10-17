using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUD : MonoBehaviour
{
    [Tooltip("A reference to the overview map game object in the UI for the scene.")]
    [SerializeField] private GameObject overviewMap;

    // Start is called before the first frame update
    void Start()
    {
        //toggles overview map off if its active at start
        if (overviewMap.activeSelf == true)
        {
            ToggleOverviewMap();
        }
    }

    // Update is called once per frame
   private void Update()
    {
        //if player press "M", toggles overview map
        if (Input.GetButtonDown("Toggle Map") == true)
        {
            ToggleOverviewMap();
        }
    }

    //Toggles the overview map
    public bool ToggleOverviewMap()
    {
        overviewMap.SetActive(!overviewMap.activeSelf);
        return overviewMap.activeSelf;
    }
}
