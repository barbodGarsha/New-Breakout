using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{

    public Brick brick_data = null;
    public SpriteRenderer sprite_renderer = null;
    
    int image_index = 0;
    int lives;
    // Start is called before the first frame update
    void Start()
    {
        sprite_renderer.sprite = brick_data.images[0];
        if (brick_data.type == BrickTypes.BREAKABLE)
        {
            lives = brick_data.images.Length - 1;
            //TODO:telling the level model that a brick is made?
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (brick_data.type != BrickTypes.UNBREAKABLE)
            {
                if (lives > 0)
                {
                    image_index++;
                    lives--;
                    sprite_renderer.sprite = brick_data.images[image_index];
                }
                else
                {
                    //TODO:Telling the Level Controller that a it is destroyed and adding points
                    Destroy(gameObject);
                }
            }
        }
    }


}
