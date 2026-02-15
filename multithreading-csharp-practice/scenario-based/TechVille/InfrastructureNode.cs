using System.Collections.Generic;

public class InfrastructureNode
{
    private string name;
    private List<InfrastructureNode> children;

    public InfrastructureNode(string name)
    {
        this.name = name;
        children = new List<InfrastructureNode>();
    }

    public string GetName() => name;
    public List<InfrastructureNode> GetChildren() => children;

    public void AddChild(InfrastructureNode child)
    {
        children.Add(child);
    }

    public override string ToString()
    {
        return name;
    }
}
