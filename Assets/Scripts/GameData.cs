﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BrickTypes
{
    BREAKABLE,
    UNBREAKABLE
}

public class Ui 
{
    [Flags]
    public enum UiUpdate
    {
        NONE = 0,
        LIVES = 1 << 0,
        SCORE = 1 << 1,
        SCREEN = 1 << 2,
        ALL = LIVES | SCORE | SCREEN
    }

    public UiUpdate ui_update = UiUpdate.ALL;
}
public class BallModel
{

    public const float OFFSET = 0.377f;
    public const float SPEED = 10f;

    public Vector3 pos;
    public Vector2 direction = new Vector2(0, 1);

    public bool is_simulation_on = false;
    public bool ball_hit = false;
    public Collision2D col;
}

public class PaddleModel
{
    //Just in case we added playing with keyboard
    public const float SPEED = 20f;

    public const float LEFT_MAX = -10.06f;
    public const float RIGHT_MAX = 10.06f;

    public Vector3 pos = new Vector3(0, 0, 0);

}

public class GameModel
{
    public enum status
    {
        PLAYING,
        PAUSE,
        WON,
        GAMEOVER
    }

    public status game_status = status.PLAYING;
    public int bricks = 23;
    public int lives = 3;
    public int score = 0;

}



public class GameData : MonoBehaviour
{
    private static GameData _instance;

    public static GameData instance { get { return _instance; } }

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }



    public BallModel ball_model = new BallModel();

    public PaddleModel paddle_model = new PaddleModel();

    public GameModel game_model = new GameModel();

    public Ui ui_model = new Ui();
}