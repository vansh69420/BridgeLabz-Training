using System;
public class ParcelStage
{
    private string stageName;

    public ParcelStage(string stageName)
    {
        this.stageName = stageName;
    }

    public string GetStageName()
    {
        return stageName;
    }

    public override string ToString()
    {
        return stageName;
    }

    public override bool Equals(object obj)
    {
        ParcelStage other = obj as ParcelStage;
        return other != null && stageName.Equals(other.stageName);
    }
}
