using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class CallingPoint
{

    [XmlElement("locationName")]
    public string LocationName { get; set; } = "";

    [XmlElement("crs")]
    public string Crs { get; set; } = "";

    [XmlElement("st")]
    public string St { get; set; } = "";

    [XmlElement("et")]
    public string Et { get; set; } = "";

    [XmlElement("at")]
    public string At { get; set; } = "";

    [XmlElement("isCancelled")]
    public bool? IsCancelled { get; set; }
    
    [XmlElement("length")]
    public int Length { get; set; }

    [XmlElement("detachFront")]
    public bool? DetachFront { get; set;}

    [XmlElement("formation")]
    public Formation? Formation { get; set; }

    [XmlElement("adhocAlerts")]
    public List<string> AdhocAlerts { get; set; } = [];

    [XmlElement("cancelReason")]
    public string? CancelReason { get; set; }
    [XmlElement("delayReason")]
    public string? DelayReason { get; set; }

    [XmlElement("affectedByDiversion")]
    public string? AffectedByDiversion { get; set; }

    [XmlElement("rerouteDelay")]
    public int? RerouteDelay { get; set; }

    [XmlElement("uncertainty")]
    public Uncertainty? Uncertainty { get; set; }


}