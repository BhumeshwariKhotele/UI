using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlManager : MonoBehaviour
{
    public GameObject OptionPanel;
     public GameObject TopPanel, MiddlePanel;
   public void OptionsMenu()
   {
       OptionPanel.SetActive(true);
       TopPanel.SetActive(false);
       MiddlePanel.SetActive(false);
   }

   public void BackOption()
   {
        OptionPanel.SetActive(false);
       TopPanel.SetActive(true);
       MiddlePanel.SetActive(true);
   }
}
