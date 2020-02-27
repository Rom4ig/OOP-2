using System;
using WpfApp5.NewFolder1;

namespace WpfApp5
{
    public class UnitToWork
    {
        private MobileContext db = new MobileContext();
        public Phone phone;

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
