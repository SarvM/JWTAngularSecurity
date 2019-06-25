using WebApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Mock_Data
{
    public class PackageData
    {
        public static IEnumerable<Package> FetchPackage(){
            List<Package> packages = new List<Package>(){
                new Package("1764e65d-dbdc-4d0b-8cae-b49b436a9266", "Channel 1", "Premimum", "$150", "Channel 1 Description","CanAccessPremimum"),
                new Package("2acc50ae-a576-4ad9-8ff0-5fd6bdd024f6", "Channel 2", "Standard", "$120", "Channel 2 Description","CanAccessStandard"),
                new Package("b9e65398-a5a2-4968-b004-a82cdd0e39b1", "Channel 3", "Free", "$0", "Channel 3 Description","['CanAccessStandard','CanAccessPremimum']"),
            };

            return packages;
        }
    }
}