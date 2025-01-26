using UnityEngine;

public enum TypeOfBullet
{
    Regular,
    Explosive,
    Piercing
}

[CreateAssetMenu(fileName = "NewGun", menuName = "ggj2025/Gun", order = 1)]
public class GunScriptable : ScriptableObject
{
    public string name; 
    public TypeOfBullet bulletType; 
    public Sprite sprite; 
}