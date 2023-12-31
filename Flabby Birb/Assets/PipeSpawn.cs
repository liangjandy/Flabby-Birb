using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float maxTime = 5;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.RandomRange(-height, height), 0);
            Destroy(newpipe, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
