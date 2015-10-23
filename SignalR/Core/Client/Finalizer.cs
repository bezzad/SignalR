
using System;

namespace SignalR.Core
{
    public abstract class Finalizer : IDisposable
    {
        // Prevent dispose from happening more than once
        public bool Disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Function called via Dispose method or via Finalizer
        protected void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                this.Disposed = true;

                // if this is a dispose call dispose on all state you
                // hold, and take yourself off the Finalization queue.
                if (disposing)
                {
                    // free your own state (managed objects)
                    ReleaseManagedMemory();
                }

                // free your own state (unmanaged objects)
                ReleaseUnManagedMemory();
            }
        }

        protected virtual void ReleaseManagedMemory() { }
        protected virtual void ReleaseUnManagedMemory() { }

        public virtual void ThrowExceptionIfDisposed()
        {
            if (Disposed)
                throw new ObjectDisposedException("This object disposed before calling.");
        }

        ~Finalizer()
        {
            Dispose(false);
        }
    }
}

