using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


[XmlRoot(ElementName = "GetArrBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/")]
public class GetArrBoardWithDetailsResponse
{
    [XmlElement(ElementName = "GetStationBoardResult")]
    public required StationBoardWithDetails StationBoardWithDetails { get; set; }
}