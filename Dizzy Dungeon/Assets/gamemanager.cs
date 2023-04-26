using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
   
    public static int checklvl;
    public GameObject[] toturnoff;
    public GameObject[] levels;
    public AudioSource Audio;
    public GameObject pauseButton;
    GameObject SpwanPrefab;
    public GameObject gamewinPanel;
    public GameObject gameoverPanel;

    //public GameObject[] Player;
    //Vector3[] ObjectPostion;

     GameObject[] smile;
    Vector3[] smilePosition;

     GameObject[] Spikes;

    GameObject playerActive;
    Vector3 PlayerActivePosition;
    
    void Start()
    {
        //PlayerController.canMove = false;
        //Mobile.canMove = false;
    }
    public void isLevelActive()
    {
        
        if (playerActive = GameObject.FindGameObjectWithTag("Player"))

        {
            if (playerActive.activeInHierarchy)
            {

                PlayerActivePosition = playerActive.transform.position;
                Debug.Log("PlayerPosition" + PlayerActivePosition);
            }
            smile = GameObject.FindGameObjectsWithTag("Enemy");
            {
                smilePosition = new Vector3[smile.Length];
                Debug.Log("Smile");
                for (int k = 0; k < smile.Length; k++)
                {
                    if (smile[k].activeInHierarchy)
                    {
                        Debug.Log("Smile For loop");

                        smilePosition[k] = smile[k].transform.position;
                        Debug.Log("Smile " + smilePosition[k]);
                    }
                }
            }

            Spikes = GameObject.FindGameObjectsWithTag("Trap");
            {
                for (int t = 0; t < Spikes.Length; t++)
                {
                    if (Spikes[t].activeInHierarchy)
                    {
                        Debug.Log("Spike is active");
                    }
                }
            }
        }

    }
    public void chcklevel(int check)
    {
        checklvl = check;
      
    }


    public void Retrylevel()
    {

        for (int k = 0; k < toturnoff.Length; k++)
        {


            toturnoff[k].SetActive(false);
            Audio.Stop();
            pauseButton.SetActive(true);
            gameoverPanel.SetActive(false);
            gamewinPanel.SetActive(false);

        }
    }
    public void nextlevel()
    {
       
        playerActive.gameObject.SetActive(true);
        playerActive.transform.position = PlayerActivePosition;

        for (int j = 0; j < smile.Length; j++)
        {

            smile[j].gameObject.SetActive(true);
            smile[j].transform.position = smilePosition[j];
        }

        for (int k = 0; k < Spikes.Length; k++)
        {
            Spikes[k].gameObject.SetActive(true);
        }

        checklvl += 1;

        if (checklvl < 5)
            
        {
           
            for (int i = 0; i < levels.Length; i++)
            {
                // PlayerController.canMove = false;
                PlayerController.canMoveUp = false;
                PlayerController.canmoveDown = false;
                PlayerController.canMoveLeft = false;
                PlayerController.canMoveright = false;


                
                Mobile.canMoveUp = false;
                Mobile.canmoveDown = false;
                Mobile.canMoveLeft = false;
                Mobile.canMoveright = false;
                // SwipeDectection.Movement = false;
                if (checklvl == i)
                {
                    
                    Debug.Log("Error");
                    
                    levels[i].SetActive(true);
                    Audio.Stop();
                    pauseButton.SetActive(true);
                   
                   

                }
                
                else
                {


                    levels[i].SetActive(false);
                   


                }
                StartCoroutine(LeveActiveTimer());
            }
                for (int k = 0; k < toturnoff.Length; k++)
                {


                    toturnoff[k].SetActive(false);
                    Audio.Stop();
                    pauseButton.SetActive(true);
                    gameoverPanel.SetActive(false);
                    gamewinPanel.SetActive(false);
                

            }
            
        }
        else 
        {
          
            checklvl = 0;
           
            for (int i = 0; i < levels.Length; i++)
            {
               // PlayerController.canMove = false;
                PlayerController.canMoveUp = false;
                PlayerController.canmoveDown = false;
                PlayerController.canMoveLeft = false;
                PlayerController.canMoveright = false;
                if (checklvl == i)
                {
                    Debug.Log("check");
                    levels[i].SetActive(true);
                    Audio.Stop();
                    pauseButton.SetActive(true);
                   
                   

                }
                else
                {
                    levels[i].SetActive(false);
                }
                StartCoroutine(LeveActiveTimer());
            }
            //StartCoroutine(LeveActiveTimer());
            for (int k = 0; k < toturnoff.Length; k++)
            {
                toturnoff[k].SetActive(false);
                Audio.Stop();
                pauseButton.SetActive(true);
                

                
            }
        }
        if (playerActive = GameObject.FindGameObjectWithTag("Player"))

        {
            if (playerActive.activeInHierarchy)
            {

                PlayerActivePosition = playerActive.transform.position;
                Debug.Log("PlayerPosition" + PlayerActivePosition);

            }
            smile = GameObject.FindGameObjectsWithTag("Enemy");
            {
                smilePosition = new Vector3[smile.Length];
                Debug.Log("Smile");
                for (int k = 0; k < smile.Length; k++)
                {
                    if (smile[k].activeInHierarchy)
                    {
                        Debug.Log("Smile For loop");

                        smilePosition[k] = smile[k].transform.position;
                        Debug.Log("Smile " + smilePosition[k]);
                    }
                }
            }
            Spikes = GameObject.FindGameObjectsWithTag("Trap");
            {
                for (int t = 0; t < Spikes.Length; t++)
                {
                    if (Spikes[t].activeInHierarchy)
                    {
                        Debug.Log("Spike is active");
                    }
                }
            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SpwanPrefab = GameObject.FindGameObjectWithTag("Prefabs");
        //Debug.Log("Prefabs" + SpwanPrefab);
        Destroy(SpwanPrefab);

        SceneManager.LoadScene("Main Menu");
       // Time.timeScale = 1f;
    }
    IEnumerator LeveActiveTimer()
    {



        yield return new WaitForSeconds(0.2f);
        //PlayerController.canMove = false;
        PlayerController.canMoveUp = true;
        PlayerController.canmoveDown = true;
        PlayerController.canMoveLeft = true;
        PlayerController.canMoveright = true;

        Mobile.canMoveUp = true;
        Mobile.canmoveDown = true;
        Mobile.canMoveLeft = true;
        Mobile.canMoveright = true;
        // SwipeDectection.Movement = true;
    }
}
