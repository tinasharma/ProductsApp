using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*using Microsoft.Framework.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
//using LogLevel = Microsoft.Framework.Logging.LogLevel;
using Microsoft.Azure;*/

namespace ProductsApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        /*CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("<tinasharma>_AzureStorageConnectionString"));

        // Create the table client.
        CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

        // Get a reference to a table named "productTable"
        CloudTable table = tableClient.GetTableReference("productTable");

        // Create the CloudTable if it does not exist
        await table.CreateIfNotExistsAsync();*/
    }

    
}