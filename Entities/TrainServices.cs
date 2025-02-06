using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

[XmlRoot("trainServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
public class TrainServices
{
    [XmlArray("service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
    public List<Service> Services { get; set; } = [];
}
