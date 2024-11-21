using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using JetBrains.Annotations;

public class ButtonBehaviour : MonoBehaviour
{
   

    public void MoveTOScene(int scenceID)
    {
        SceneManager.LoadScene(scenceID);


    }
     
    
}
