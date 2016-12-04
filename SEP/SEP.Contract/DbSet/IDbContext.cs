namespace SEP.Contract.DbSet
{
    public interface IDbContext
    {
        int Complete();

        void Rollback();
    }
}