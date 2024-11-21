using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{

    public BallController ballMovement;

    public ScoreController scoreController;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHieght = c.collider.bounds.size.y;
        float x;
        if(c.gameObject.name == "RacketPlayer1")
        {
            x = 1;

        }
        else
        {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketHieght;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer" || collision.gameObject.name == "RacketPlayer2")

        {
            this.BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "WallLft")
        {
            Debug.Log("Collision with WallLeft");
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.Startball(true));

        }
        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collistion with WallRight");
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.Startball(false));
        }

    }
}
