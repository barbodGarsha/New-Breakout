using UnityEngine;
using System;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject
{
    public float value;

    public float GetValue
    {
        get { return value; }
    }

    public void SetValue(float Value)
    {
        value = Value;
    }

    public void SetValue(FloatVariable Value)
    {
        value = Value.value;
    }

}

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
    public int value;

    public int GetValue
    {
        get { return value; }
    }

    public void SetValue(int Value)
    {
        value = Value;
    }

    public void SetValue(IntVariable Value)
    {
        value = Value.value;
    }
}


[CreateAssetMenu]
public class BoolVariable : ScriptableObject
{
    public bool value;

    public bool GetValue
    {
        get { return value; }
    }

    public void SetValue(bool Value)
    {
        value = Value;
    }

    public void SetValue(BoolVariable Value)
    {
        value = Value.value;
    }
}


[CreateAssetMenu]
public class Brick : ScriptableObject
{

    public BrickTypes type;
    public int points;
    public Sprite[] images;


}
