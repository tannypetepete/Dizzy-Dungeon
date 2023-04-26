using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Arlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ArlevelSelection()
    {
        SceneManager.LoadScene("Ar");
       // SceneManager.LoadScene("ArLevelSelection");
    }
}
