public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public virtual int RecordEvent()
    {
        return _points;
    }
    public virtual string GetStatus()
    {
        return "[ ]";
    }
    public virtual string GetDetails()
    {
        return $"{GetStatus()} {_name} ({_description})";
    }
    public virtual string GetSaveString()
    {
        return "";
    }
}