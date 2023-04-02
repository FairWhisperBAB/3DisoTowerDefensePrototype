using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTower", menuName = "Towers")]
public class TowerSO : ScriptableObject
{
    [SerializeField] public GameObject turretPrefab;

    [Header("INFO")]
    [SerializeField] private string _name;
    [SerializeField] private int _cost;
    [TextArea] [SerializeField] private string _description;

    [Header("STATS")]
    [SerializeField] private int _damage;
    [SerializeField] private int _range;
    [SerializeField] private float _fireRate;


    //info
    public string Name => _name;
    public int Cost => _cost;
    public string Description => _description;

    //stats
    public int Damage => _damage;
    public int Range => _range;
    public float FireRate => _fireRate;

}