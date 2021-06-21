using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class BirdController : MonoBehaviour
{
    [SerializeField] Text scoreText;
    Rigidbody2D bird;
    int score = 0;
    public bool dead = false;
    public GameObject gameovertxt;
    public GameObject bg;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        bird = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && !dead)
        {
            bird.velocity = new Vector2(0, 8.5f);
            Debug.Log("Space bar");
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnCollisionEnter2D()
    {
        dead = true;
        score = 0;
      
        Debug.Log("Dead");
        gameovertxt.active = true;
        bg.active = true;
        this.gameObject.GetComponent<Animator>().enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "PointsTrigger")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
