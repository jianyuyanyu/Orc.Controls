﻿namespace Orc.Automation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Windows.Automation;
    using Catel;
    using Catel.IoC;

    public static class AutomationHelper
    {
        private const int MaxStackTraceLookUp = 5;

        public static string GetCallingProperty()
        {
            var stackTrace = new StackTrace();
            for (var i = 1; i <= MaxStackTraceLookUp; i++)
            {
                var callingProperty = stackTrace.GetFrame(i)?.GetMethod()?.Name;
                if (callingProperty is null)
                {
                    continue;
                }

                if (callingProperty.StartsWith("get_") || callingProperty.StartsWith("set_"))
                {
                    return callingProperty.Replace("get_", string.Empty)
                        .Replace("set_", string.Empty);
                }
            }

            return null;
        }

        public static object WrapAutomationObject(Type type, object value)
        {
            Argument.IsNotNull(() => value);

            var typeFactory = value.GetTypeFactory();

            if (typeof(AutomationBase).IsAssignableFrom(type))
            {
                return typeFactory.CreateInstanceWithParametersAndAutoCompletion(type, value);
            }

            if (type == typeof(AutomationElement))
            {
                return value;
            }

            var collectionElementType = type.GetAnyElementType();
            if (collectionElementType is null)
            {
                return null;
            }

            if (value is not IEnumerable<AutomationElement> valueElements)
            {
                return null;
            }

            if (typeFactory.CreateInstanceWithParametersAndAutoCompletion(type) is not IList elementCollection)
            {
                return null;
            }

            if (typeof(AutomationBase).IsAssignableFrom(collectionElementType))
            {
                foreach (var automationElement in valueElements)
                {
                    elementCollection.Add(typeFactory.CreateInstanceWithParametersAndAutoCompletion(collectionElementType, automationElement));
                }

                return elementCollection;
            }

            if (type == typeof(AutomationElement))
            {
                foreach (var automationElement in valueElements)
                {
                    elementCollection.Add(automationElement);
                }

                return elementCollection;
            }

            return null;
        }
    }
}
