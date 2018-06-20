namespace NClass.Document
{
    public interface IIdentityGenerator
    {
        int NewId { get; }

        void Register(int id);


    }
}