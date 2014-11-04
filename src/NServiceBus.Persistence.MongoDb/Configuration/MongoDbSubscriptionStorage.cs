﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.Features;
using NServiceBus.Persistence.MongoDB.Configuration;
using NServiceBus.Persistence.MongoDB.SubscriptionPersistence;

namespace NServiceBus.Persistence.MongoDB.SagaPersistence
{
    public class MongoDbSubscriptionStorage : Feature
    {
        internal MongoDbSubscriptionStorage()
        {
            DependsOn<MongoDbStorage>();
        }

        /// <summary>
        /// Called when the feature should perform its initialization. This call will only happen if the feature is enabled.
        /// </summary>
        protected override void Setup(FeatureConfigurationContext context)
        {
            context.Container.ConfigureComponent<MongoDbSubscriptionPersistence>(DependencyLifecycle.InstancePerCall);
        }
    }
}
