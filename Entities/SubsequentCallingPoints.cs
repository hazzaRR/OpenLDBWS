using System.Xml.Serialization;
using TrainDepartureBoard.Entities;

namespace TrainDepartureBoard.Entities;

public class SubsequentCallingPoints
{
    [XmlArray("callingPointList")]
    public List<CallingPoint> CallingPoints {get; set;} = [];
}