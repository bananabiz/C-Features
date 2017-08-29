﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MineSweeper2D
{ 
    [RequireComponent(typeof(SpriteRenderer))]
public class Tile : MonoBehaviour
    {
        //store x and y coordinate in array for later use
        public int x = 0;
        public int y = 0;
        public bool isMine = false; //is the current tile a mine?
        public bool isRevealed = false; //has the tile already been revealed?

        [Header("References")]
        public Sprite[] emptySprites; // list of empty sprites i.e, empty 1,2,3,4, etc...
        public Sprite[] mineSprites; //the mine sprites

        private SpriteRenderer rend; //reference to sprite renderer

        void Awake()
        {
            //grab reference to sprite renderer
            rend = GetComponent<SpriteRenderer>();
        }
        
	    // Use this for initialization
	    void Start ()
        {
            //randomly decide if it's a mine or not
            isMine = Random.value < 0.05f;
	    }

        public void Reveal(int adjacentMines, int mineState = 0)
        {
            //flags the tile as being revealed
            isRevealed = true;
            //checks if tile is a mine
            if (isMine)
            {
                //sets sprite to mine sprite
                rend.sprite = mineSprites[mineState];
            }
            else
            {
                //sets sprite to appropriate texture based on adjacent mines
                rend.sprite = emptySprites[adjacentMines];
            }
        }

	    // Update is called once per frame
	    void Update ()
        {
	    	
	    }
    }
}
