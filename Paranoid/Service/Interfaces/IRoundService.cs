using Paranoid.Model;
using static Paranoid.Model.LocationConfig;

namespace Paranoid.Service.Interfaces
{
    public interface IRoundService
    {
        public LocationConfig GetLocationConfig();
    }
}
