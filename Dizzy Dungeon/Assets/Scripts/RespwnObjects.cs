using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespwnObjects : MonoBehaviour
{

     public GameObject[] Player;
      Vector3[] ObjectPostion;
    
    public GameObject gameoverPanle;
    public GameObject gameWinPanle;
    public AudioSource Audio;
    public GameObject pauseButton;
   // public AudioClip clip;
   
    public GameObject[] smile;
    Vector3[] smilePosition;

    public GameObject[] Spikes;

    public GameObject[] goal;
    // Start is called before the first frame update
    void Awake()
    {
        ObjectPostion = new Vector3[Player.Length];

        for(int i =0; i<Player.Length;i++)
        {
            ObjectPostion[i] = Player[i].transform.position;
           // Debug.Log("PlayerPosition" + ObjectPostion[i]);
        }

       // Player = GameObject.FindGameObjectWithTag("Player");
        

       // smile = GameObject.FindGameObjectsWithTag("Enemy");

        smilePosition = new Vector3[smile.Length];

        for (int i = 0; i < smile.Length; i++)
        {
            smilePosition[i] = smile[i].transform.position;
        }

      //  Spikes = GameObject.FindGameObjectsWithTag("Trap");

        //goal = GameObject.FindGameObjectWithTag("Goal");
        //Debug.Log("Player name" + ObjectPostion);
       // Player = GameObject.Find("P")
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    public void Retrylevel()

    {
        gameoverPanle.SetActive(false);
        gameWinPanle.SetActive(false);
        Audio.Stop();
        pauseButton.SetActive(true);
        for (int i = 0; i < Player.Length; i++)
        {
            Player[i].gameObject.SetActive(true);
            Player[i].transform.position = ObjectPostion[i];
        }


        for (int i = 0; i < smile.Length; i++)
        {
            
        smile[i].gameObject.SetActive(true);
        smile[i].transform.position = smilePosition[i];
        }


        for (int i = 0; i < Spikes.Length; i++)
        {
            Spikes[i].gameObject.SetActive(true);
        }


        for (int i = 0; i < goal.Length; i++)
        {
            goal[i].gameObject.SetActive(true);
        }
       
    }
}
