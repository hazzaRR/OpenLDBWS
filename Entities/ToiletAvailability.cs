using System.Xml.Serialization;
using TrainDepartureBoard.Enums;

namespace TrainDepartureBoard.Entities;

public class ToiletAvailability
{

    [XmlElement("status")]
    public ToiletStatus Status { get; set; }


    [XmlElement("value")]
    public ToiletType Value { get; set; }
}