using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] float offset;
    private Vector2 startPos;
    private float newXpos;
    BirdController birdController;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        birdController = FindObjectOfType<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdController.dead == false)
        {
            newXpos = Mathf.Repeat(Time.time * -moveSpeed, offset);
            transform.position = startPos + Vector2.right * newXpos;
        }
    }
}
