using System.Xml.Serialization;
using TrainDepartureBoard.Enums;

namespace TrainDepartureBoard.Entities;

public class Uncertainty
{
    [XmlElement("status")]
    public UncertaintyStatus Status { get; set;}

    [XmlElement("reason")]
    public string Reason { get; set;} = "";
}