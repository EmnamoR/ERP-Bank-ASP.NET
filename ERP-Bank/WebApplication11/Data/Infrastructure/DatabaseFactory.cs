using Data.Models;

namespace bank.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private bankContext dataContext;
        public bankContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new bankContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
