using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class randomlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Randomlevel()
    {
        int RanDom = Random.Range(0, 4);
        switch(RanDom)
        {
            case 0:
                SceneManager.LoadScene("Level 1");
                break;
            case 1:
                SceneManager.LoadScene("Level 2");
                break;
            case 2:
                SceneManager.LoadScene("Level 3");
                break;
            case 3:
                SceneManager.LoadScene("Level 4");
                break;
            case 4:
                SceneManager.LoadScene("Level 5");
                break;
           
        }
    }
}
