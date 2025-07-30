using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "Screen", menuName = "Data/Inventory Object", order = 1)]
public class HealthPotionSO : ItemSO
{

    [SerializeField] private float healing = 5f;

    public override void Use(GameObject user)
    {
        LifeController life = user.GetComponent<LifeController>();
        life.AddHp(healing);
    }
}
