using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcadeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public settings set;
    public void quit()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    public void setting()
    {

    }

    public void resume()
    {
        set.resume();
    }
}
