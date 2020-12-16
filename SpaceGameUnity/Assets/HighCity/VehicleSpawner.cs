using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    private const int SPAWN_EVERY = 2700;
    private const int MAX_INSTANCES = 200;
    
    public GameObject vehiclePrefab;
    
    private int _spawnedInstances = 0;
    private float _time = SPAWN_EVERY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerTick() && _spawnedInstances < MAX_INSTANCES)
        {
            SpawnInstance();
        }
    }

    private bool TimerTick()
    {
        _time -= Time.deltaTime * 1000;
        if (_time <= 0)
        {
            _time = SPAWN_EVERY;
            return true;
        }

        return false;
    }

    private void SpawnInstance()
    {
        var vehicle = Instantiate(vehiclePrefab);
        vehicle.transform.position = transform.position;
        _spawnedInstances++;
    }
}
