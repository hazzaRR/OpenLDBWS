using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class BaseService
{
    [XmlElement("rsid")]
    public string? Rsid { get; set; }

    [XmlArray("origin")]
    [XmlArrayItem("ServiceLocation")]
    public List<ServiceLocation> Origin { get; set; } = [];

    [XmlArray("destination")]
    [XmlArrayItem("ServiceLocation")]
    public List<ServiceLocation> Destination { get; set; } = [];

    [XmlArray("currentOrigins")]
    [XmlArrayItem("ServiceLocation")]
    public List<ServiceLocation> CurrentOrigins { get; set; } = [];

    [XmlArray("currentDestinations")]
    [XmlArrayItem("ServiceLocation")]
    public List<ServiceLocation> CurrentDestinations { get; set; } =[];

    [XmlElement("sta")]
    public string? Sta { get; set; }

    [XmlElement("eta")]
    public string? Eta { get; set; }

    [XmlElement("std")]
    public string? Std { get; set; }

    [XmlElement("etd")]
    public string? Etd { get; set; }

    [XmlElement("platform")]
    public string? Platform { get; set; }

    [XmlElement("operator")]
    public string? Operator { get; set; }

    [XmlElement("operatorCode")]
    public string? OperatorCode { get; set; }

    [XmlElement("isCircularRoute")]
    public bool IsCircularRoute { get; set; }

    [XmlElement("isCancelled")]
    public bool IsCancelled { get; set; }

    [XmlElement("filterLocationCancelled")]
    public bool FilterLocationCancelled { get; set; }

    [XmlElement("serviceType")]
    public string ServiceType { get; set; } = "";

    [XmlElement("length")]
    public int Length { get; set; } = 0;

    [XmlElement("detachFront")]
    public bool DetachFront { get; set; }

    [XmlElement("isReverseFormation")]
    public bool IsReverseFormation { get; set; }

    [XmlElement("cancelReason")]
    public string? CancelReason { get; set; }

    [XmlElement("delayReason")]
    public string? DelayReason { get; set; }

    [XmlElement("serviceID")]
    public string ServiceID { get; set; } = "";

    [XmlArray("adhocAlerts")]
    [XmlArrayItem("alert")]
    public List<string> AdhocAlerts { get; set; } = [];

    [XmlElement("formation")]
    public Formation? Formation { get; set; }

    [XmlElement("futureCancellation")]
    public bool FutureCancellation { get; set; }

    [XmlElement("futureDelay")]
    public bool FutureDelay { get; set; }

    [XmlElement("diversion")]
    public ServiceDiversion? Diversion { get; set; }

    [XmlElement("uncertainty")]
    public Uncertainty? Uncertainty { get; set; }

}