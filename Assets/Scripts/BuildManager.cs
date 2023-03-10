using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one Build Manager in scene");
            return;
        }
        instance = this;
    }

    [Header("TOWER TYPES")]
    public Towers ArrowTower;
    public Towers BombTower;
    public Towers MageTower;

    [Header("other")]
    private GameObject turretToBuild;

    public GameObject GetTurretToBuild() 
    { 
        return turretToBuild;
    }

    public void SetTurretToBuild(Towers towerType)
    {
        turretToBuild = towerType.turretPrefab;
    }
}
