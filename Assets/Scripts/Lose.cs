using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    [SerializeField]
     TextMeshProUGUI counter;
     float points;
     bool lost;
     [SerializeField]
     GameObject[] spawners;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!lost)
        {
            counter.text =  ((int)(points / 5)).ToString();
        }
        if((int)(points / 5) > 10)
        {
spawners[0].SetActive(true);
        }
         if((int)(points / 5) > 25)
         {
spawners[1].SetActive(true);
         }
          if((int)(points / 5) > 50)
          {
spawners[2].SetActive(true);
          }
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
              lost = true;
              counter.text = "Final Score: "+ ((int)(points / 5)).ToString();
              Invoke("Reload", 5f);
              FindObjectOfType<PlayerMovement>().rb.freezeRotation = false;
        }
        if(!lost)
        {
            points++;
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
