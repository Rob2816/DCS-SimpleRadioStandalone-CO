namespace Ciribob.DCS.SimpleRadio.Standalone.Client.Network.CODCSAirspace.Models;

// {"controller":{"altitude":34,"isFlying":false,"latitude":45.03800822794648,"longitude":39.18813534903283}}
public class CODCSAirspaceMessageWrapper
{
    public CODCSAirspacePosition controller;

    public CODCSAirspaceLineOfSightResponse los;

    //class not struct so we get Nulls
    public class CODCSAirspacePosition
    {
        public double altitude;
        public bool isFlying;
        public double latitude;
        public double longitude;
    }

    public class CODCSAirspaceLineOfSightResponse
    {
        public string clientId;
        public bool see; //visible
    }
}