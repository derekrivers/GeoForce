using MvvmCross.Plugins.Messenger;

namespace GeoForce.Core.Messages
{
    public class LocationMessage : MvxMessage
    {
        public LocationMessage(object sender, double lat, double lng)
            : base(sender)
        {
            Lat = lat;
            Lng = lng;
        }

        public double Lat { get; private set; }
        public double Lng { get; private set; }
    }
}
