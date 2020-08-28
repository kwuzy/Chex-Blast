


public class Player
{
    private int level;
    private int score;
    private int damage;
    private float fireRate;
    private float fireSpeed;
    private int playerHealth;


    

    public Player() 
    {
        this.level = 1;
        this.score = 0;
        this.damage = 1;
        this.fireRate = (float)0.5;
        this.fireSpeed = 1f;
        this.playerHealth = 1;
    }
    public Player(int damage, float fireRate, float fireSpeed, int playerHealth) 
    {
        this.level = 1;
        this.score = 0;
        this.damage = damage;
        this.fireRate = fireRate;
        this.fireSpeed = fireSpeed;
        this.playerHealth = playerHealth;
    }

    public int Level {
        get {return level;}
        set {level = value;}
    }
    public int Score {
        get {return score;}
        set {score = value;}
    }
    public int Damage {
        get {return damage;}
        set {damage = value;}
    }
    public float FireRate {
        get {return fireRate;}
        set {fireRate = value;}
    }
    public float FireSpeed {
        get {return fireSpeed;}
        set {fireSpeed = value;}
    }
    public int PlayerHealth {
        get {return playerHealth;}
        set {playerHealth = value;}
    }
}