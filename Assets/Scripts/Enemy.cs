using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Enemy
{
    public Enemy(int health, string name, int score) : this()
    {
        this.Health = health;
        this.Name = name;
        this.Score = score;
    }

    public Enemy(int score) : this(3, "Goblin", score)
    {

    }

    public int Health { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }

}
