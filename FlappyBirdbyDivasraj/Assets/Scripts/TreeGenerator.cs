using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    [SerializeField] GameObject trees;
    int timer = 100;
    public BirdController birdController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer>= 100 && birdController.dead == false)
        {
            timer = 0;
            GameObject tree = Instantiate(trees, new Vector2(trees.transform.position.x + 10, trees.transform.position.y + Random.Range(-2, 2)),trees.transform.rotation);
            Destroy(tree,15);
        }
    }
}
