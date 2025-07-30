using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Screen", menuName = "Data/Inventory Object", order = 0)]
public abstract class ItemSO : ScriptableObject
{
    [SerializeField] protected int id;
    [SerializeField] protected string nome;
    [SerializeField] protected Sprite sprite;
    [SerializeField] protected string description;

    public int Id => id;
    public abstract void Use(GameObject user);

}
