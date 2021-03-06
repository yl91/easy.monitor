﻿using Easy.Domain.Application;
using Easy.Monitor.Application.Application.Api;
using Easy.Monitor.Application.Application.Directory;
using Easy.Monitor.Application.Application.Node;
using Easy.Monitor.Application.Application.ServiceHostStatMinute;
using Easy.Monitor.Application.Application.ServiceStatMinute;
using Easy.Monitor.Application.Application.StatMetaData;

namespace Easy.Monitor.Application
{
    public static class ApplicationRegistry
    {
        static ApplicationRegistry()
        {
            ApplicationFactory.Instance().Register(new StatMetaDataApplication());
            ApplicationFactory.Instance().Register(new ServiceStatMinuteApplication());
            ApplicationFactory.Instance().Register(new ServiceHostStatMinuteApplication());
            ApplicationFactory.Instance().Register(new DirectoryApplication());
            ApplicationFactory.Instance().Register(new NodeApplication());
            ApplicationFactory.Instance().Register(new ApiApplication());
        }

        public static ApiApplication Api
        {
            get
            {
                return ApplicationFactory.Instance().Get<ApiApplication>();
            }
        }

        public static NodeApplication Node
        {
            get
            {
                return ApplicationFactory.Instance().Get<NodeApplication>();
            }
        }

        public static DirectoryApplication Directory
        {
            get
            {
                return ApplicationFactory.Instance().Get<DirectoryApplication>();
            }
        }

        public static ServiceHostStatMinuteApplication ServiceHostStatMinute
        {
            get
            {
                return ApplicationFactory.Instance().Get<ServiceHostStatMinuteApplication>();
            }
        }

        public static ServiceStatMinuteApplication ServiceStatMinute
        {
            get
            {
                return ApplicationFactory.Instance().Get<ServiceStatMinuteApplication>();
            }
        }
        public static StatMetaDataApplication StatMetaData
        {
            get
            {
                return ApplicationFactory.Instance().Get<StatMetaDataApplication>();
            }
        }
    }
}
