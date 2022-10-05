using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class Player : Observer {
    GameObject player;
    ScoreEditor collisionEvent;

    public Player(GameObject enemyObj, ScoreEditor CollisionEvent) {
        this.player = player;
        this.collisionEvent = CollisionEvent;
    }

    public override void OnNotify()
    {
        score -= 1;
    }

}
