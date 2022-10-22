using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    [SerializeField]
    float range;
    [SerializeField]
    GameObject duck;
    [SerializeField]
    float Speed;

    [SerializeField]
    float maxTime;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            Instantiate(duck, new Vector3(transform.position.x, transform.position.y,transform.position.z + Random.Range(0, range)), transform.rotation).GetComponent<Rigidbody>().velocity = new Vector3(Speed, 0, 0);
            timer = maxTime - Random.Range(0, maxTime - 1);

        }
    }
}
