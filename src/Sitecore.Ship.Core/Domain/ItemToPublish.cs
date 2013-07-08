using System;
using System.Collections.Generic;

namespace Sitecore.Ship.Core.Domain
{
    public class ItemsToPublish
    {
        public List<ItemToPublish> Items { get; set; }       
        public string[] TargetDatabases { get; set; }
        public string[] TargetLanguages { get; set; }
    }

    public class ItemToPublish
    {
        public Guid ItemId { get; set; }
        public bool PublishChildren { get; set; }
    }
}
