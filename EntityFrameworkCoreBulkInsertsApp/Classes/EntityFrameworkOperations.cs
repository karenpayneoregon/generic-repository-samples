using System.Transactions;
using EntityFrameworkCoreBulkInsertsApp.Data;
using EntityFrameworkCoreBulkInsertsApp.Models;

namespace EntityFrameworkCoreBulkInsertsApp.Classes;
internal class EntityFrameworkOperations
{
    public void Work(List<Customer> customers)
    {
        using (TransactionScope scope = new TransactionScope())
        {
            Context context = null;
            try
            {
                context = new Context();
                context.ChangeTracker.AutoDetectChangesEnabled = false;

                int count = 0;
                foreach (var entityToInsert in customers)
                {
                    ++count;
                    context = AddToContext(context, entityToInsert, count, 100, false);
                }

                context.SaveChanges();
            }
            finally
            {
                if (context != null)
                {
                    context.Dispose();
                }
            }

            scope.Complete();
        }
    }
    private Context AddToContext(Context context, Customer entity, int count, int commitCount, bool recreateContext)
    {
        context.Set<Customer>().Add(entity);

        if (count % commitCount == 0)
        {
            context.SaveChanges();
            if (recreateContext)
            {
                context.Dispose();
                context = new Context();
                context.ChangeTracker.AutoDetectChangesEnabled = false;
            }
        }

        return context;
    }
}
