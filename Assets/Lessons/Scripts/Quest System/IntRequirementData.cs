using UnityEngine;

public class IntRequirementData : RequirementData
{
    public int currentValue;
    private int targetValue;

    public IntRequirementData(IntRequirementSO Config_)
    {
        Config = Config_;
        targetValue = Config_.targetValue;
        currentValue = Config_.defaultValue;
    }

    public override bool IsMet()
    {
        bool val = currentValue >= targetValue;
        return val;
    }
    public override void Reset()
    {
        currentValue = 0;
    }
    public void Increment(int amt)
    {
        currentValue += amt;
        RaiseRequirementChanged();
    }
}
