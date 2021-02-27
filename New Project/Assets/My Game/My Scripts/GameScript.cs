using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public Transform level2enemies;
	private bool level2complete = false;
	public GameObject level2rewards;
	public EnemySpawner enemySpawn;

	// Use this for initialization
	protected void Start () {
		
		level2rewards.SetActive(false);
		EnemySpawner.activated = false;
	}

	// Update is called once per frame
	protected void Update () {

		if (level2enemies.childCount == 0 && level2complete == false)
        {
			HUD.Message("You destroyed all the enemies! Now find Power Up!");
			level2complete = true;
			level2rewards.SetActive(true);
		}

		if (enemySpawn.transform.childCount == 0 && EnemySpawner.activated)
        {
			spawnWave();
        }
	
	}

	public void spawnWave()
    {
		for (int i = 0; i < 50; i++)
        {
			enemySpawn.Spawn();
        }
    }
}