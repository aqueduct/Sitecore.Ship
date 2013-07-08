using System;
using Sitecore.Ship.Core.Domain;

namespace Sitecore.Ship.Core.Contracts
{
    public interface IPublishService
    {
        void Run(PublishParameters publishParameters);
        void Run(ItemsToPublish itemsToPublish);
        DateTime GetLastCompletedRun(PublishLastCompleted completeParameters);       
    }
}