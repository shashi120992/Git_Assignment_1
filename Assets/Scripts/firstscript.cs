using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
    public Button button;
    public string scene;
    //start of script
    void start ()
    {
        button.onclick.Addlistener(OnButtonClick);

    }

    private void OnButtonClick ()
    {
        scre
        SceneManager.Loadscrene(scene)
    }

    private void update()
    {

    }
    
}
