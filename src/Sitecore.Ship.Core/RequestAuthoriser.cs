﻿using Sitecore.Ship.Core.Contracts;
using Sitecore.Ship.Core.Domain;

namespace Sitecore.Ship.Core
{
    public class HttpRequestAuthoriser : IAuthoriser
    {
        private readonly ICheckRequests _checkRequests;
        private readonly IConfigurationProvider<PackageInstallationSettings> _configurationProvider;

        public HttpRequestAuthoriser(ICheckRequests checkRequests, IConfigurationProvider<PackageInstallationSettings> configurationProvider)
        {
            _checkRequests = checkRequests;
            _configurationProvider = configurationProvider;
        }

        public bool IsAllowed()
        {
            if (! _configurationProvider.Settings.IsEnabled) return false;

            if ((!_checkRequests.IsLocal) && (!_configurationProvider.Settings.AllowRemoteAccess)) return false;

//            if ((_context.Request.HttpMethod == "POST") && (!_configurationProvider.Settings.AllowPackageStreaming)) return false;

            return true;
        }
    }
}