using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    BirdController birdController;
    // Start is called before the first frame update
    void Start()
    {
        birdController = FindObjectOfType<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(birdController.dead == false)
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - 0.5f, transform.position.y), 0.1f);
    }
}
