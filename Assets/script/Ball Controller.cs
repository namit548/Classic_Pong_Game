using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float movemnetSpeed;

    // Start is called before the first frame update
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;

    public void Start()
    {
        StartCoroutine(this.Startball());//to wait or pausea


    }
    void PostisionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }
        public IEnumerator Startball(bool isStartingplayer1  = true)
    {
        this.PostisionBall(isStartingplayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if(isStartingplayer1){
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.movemnetSpeed + this.hitCounter * extraSpeedPerHit;
        Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = dir * speed;

    }

    public void IncreaseHitCounter()
    {
        if (this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
        {

            this.hitCounter++;
        }
    }
        
}
