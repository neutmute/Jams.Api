using System;

namespace Jams.Api
{
    public class JamsContext : IDisposable, IJamsContext
    {
        public MVPSI.JAMS.Server Server { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Server != null) Server.Dispose();
            }
        }
    }
}
