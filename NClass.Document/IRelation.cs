namespace NClass.Document
{
    public interface IRelation
    {
        IEntity Left { get; set; }
        IEntity Right { get; set; }
        string Notes { get; set; }
        int Id { get; }
        string Title { get; set; }
    }
}