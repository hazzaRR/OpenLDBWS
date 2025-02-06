using TrainDepartureBoard;
using TrainDepartureBoard.Entities;

string departureStationCode = "COL";
string destinationStationCode = "LST";

LdbwsClient client = new LdbwsClient("72a8196c-6306-4f02-8194-6225e3eee456");

GetDepBoardWithDetailsResponse response = await client.GetDepBoardWithDetails(10, departureStationCode, 120, destinationStationCode);

Console.WriteLine($"{response.StationBoardWithDetails.LocationName}");

   Console.WriteLine($"{response.StationBoardWithDetails.Crs}");
   Console.WriteLine($"{response.StationBoardWithDetails.FilterCrs}");
   Console.WriteLine($"{response.StationBoardWithDetails.FilterLocationName}");
   Console.WriteLine($"{response.StationBoardWithDetails.PlatformAvailable}");
   Console.WriteLine($"{response.StationBoardWithDetails.GeneratedAt}");
   Console.WriteLine($"{response.StationBoardWithDetails.TrainServices}");

Console.WriteLine("Services leaving Colchester are:");

List<Service> services = response.StationBoardWithDetails.TrainServices.Services;

foreach (Service service in services)
{
   Console.WriteLine($"{service.Destination.Location.LocationName}");
   Console.WriteLine($"{1}");
}