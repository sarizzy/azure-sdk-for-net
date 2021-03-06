﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Azure.Messaging.ServiceBus.Management
{
    internal static class SubscriptionRuntimeInfoExtensions
    {
        public static SubscriptionRuntimeInfo ParseFromContent(string topicName, string xml)
        {
            try
            {
                var xDoc = XElement.Parse(xml);
                if (!xDoc.IsEmpty)
                {
                    if (xDoc.Name.LocalName == "entry")
                    {
                        return ParseFromEntryElement(topicName, xDoc);
                    }
                }
            }
            catch (Exception ex) when (!(ex is ServiceBusException))
            {
                throw new ServiceBusException(false, ex.Message);
            }

            throw new ServiceBusException("Subscription was not found", ServiceBusException.FailureReason.MessagingEntityNotFound);
        }

        private static SubscriptionRuntimeInfo ParseFromEntryElement(string topicName, XElement xEntry)
        {
            var name = xEntry.Element(XName.Get("title", ManagementClientConstants.AtomNamespace)).Value;
            var subscriptionRuntimeInfo = new SubscriptionRuntimeInfo(topicName, name);

            var qdXml = xEntry.Element(XName.Get("content", ManagementClientConstants.AtomNamespace))?
                .Element(XName.Get("SubscriptionDescription", ManagementClientConstants.ServiceBusNamespace));

            if (qdXml == null)
            {
                throw new ServiceBusException("Subscription was not found", ServiceBusException.FailureReason.MessagingEntityNotFound);
            }

            foreach (var element in qdXml.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case "AccessedAt":
                        subscriptionRuntimeInfo.AccessedAt = DateTimeOffset.Parse(element.Value, CultureInfo.InvariantCulture);
                        break;
                    case "CreatedAt":
                        subscriptionRuntimeInfo.CreatedAt = DateTimeOffset.Parse(element.Value, CultureInfo.InvariantCulture);
                        break;
                    case "UpdatedAt":
                        subscriptionRuntimeInfo.UpdatedAt = DateTimeOffset.Parse(element.Value, CultureInfo.InvariantCulture);
                        break;
                    case "MessageCount":
                        subscriptionRuntimeInfo.MessageCount = long.Parse(element.Value, CultureInfo.InvariantCulture);
                        break;
                    case "CountDetails":
                        subscriptionRuntimeInfo.CountDetails = new MessageCountDetails();
                        foreach (var countElement in element.Elements())
                        {
                            switch (countElement.Name.LocalName)
                            {
                                case "ActiveMessageCount":
                                    subscriptionRuntimeInfo.CountDetails.ActiveMessageCount = long.Parse(countElement.Value, CultureInfo.InvariantCulture);
                                    break;
                                case "DeadLetterMessageCount":
                                    subscriptionRuntimeInfo.CountDetails.DeadLetterMessageCount = long.Parse(countElement.Value, CultureInfo.InvariantCulture);
                                    break;
                                case "ScheduledMessageCount":
                                    subscriptionRuntimeInfo.CountDetails.ScheduledMessageCount = long.Parse(countElement.Value, CultureInfo.InvariantCulture);
                                    break;
                                case "TransferMessageCount":
                                    subscriptionRuntimeInfo.CountDetails.TransferMessageCount = long.Parse(countElement.Value, CultureInfo.InvariantCulture);
                                    break;
                                case "TransferDeadLetterMessageCount":
                                    subscriptionRuntimeInfo.CountDetails.TransferDeadLetterMessageCount = long.Parse(countElement.Value, CultureInfo.InvariantCulture);
                                    break;
                            }
                        }
                        break;
                }
            }

            return subscriptionRuntimeInfo;
        }

        public static List<SubscriptionRuntimeInfo> ParseCollectionFromContent(string topicPath, string xml)
        {
            try
            {
                var xDoc = XElement.Parse(xml);
                if (!xDoc.IsEmpty)
                {
                    if (xDoc.Name.LocalName == "feed")
                    {
                        var subscriptionList = new List<SubscriptionRuntimeInfo>();

                        var entryList = xDoc.Elements(XName.Get("entry", ManagementClientConstants.AtomNamespace));
                        foreach (var entry in entryList)
                        {
                            subscriptionList.Add(ParseFromEntryElement(topicPath, entry));
                        }

                        return subscriptionList;
                    }
                }
            }
            catch (Exception ex) when (!(ex is ServiceBusException))
            {
                throw new ServiceBusException(false, ex.Message);
            }

            throw new ServiceBusException("No subscriptions were found", ServiceBusException.FailureReason.MessagingEntityNotFound);
        }
    }
}
