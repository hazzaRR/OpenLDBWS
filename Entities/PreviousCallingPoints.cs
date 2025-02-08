using System.Xml.Serialization;
using TrainDepartureBoard.Entities;

namespace TrainDepartureBoard.Entities;

public class PreviousCallingPoints
{
    [XmlArray("callingPointList")]
    [XmlArrayItem(ElementName = "callingPoint")]
    public List<CallingPoint> CallingPoints {get; set;} = [];
}