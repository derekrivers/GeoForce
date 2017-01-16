using MvvmCross.Plugins.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoForce.Core.Services
{
    public interface ILocationService
    {
        void OnLocation(MvxGeoLocation location);
        void OnError(MvxLocationError error);
    }
}
