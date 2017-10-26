using MVPSI.JAMS;

namespace Jams.Api
{
    public interface IJamsContext
    {
        Server Server { get; set; }

        void Dispose();
    }
}