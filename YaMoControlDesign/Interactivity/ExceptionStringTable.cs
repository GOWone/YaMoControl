﻿using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace YaMoControlDesign.Interactivity
{

    internal class ExceptionStringTable
    {
        private static ResourceManager ResourceMan;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (ResourceMan == null)
                {
                    return ResourceMan = new ResourceManager(nameof(ExceptionStringTable), typeof(ExceptionStringTable).Assembly);
                }
                return ResourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture { get; set; }

        internal static string CannotHostBehaviorCollectionMultipleTimesExceptionMessage =>
            ResourceManager.GetString(nameof(CannotHostBehaviorCollectionMultipleTimesExceptionMessage), Culture);

        internal static string CannotHostBehaviorMultipleTimesExceptionMessage =>
            ResourceManager.GetString(nameof(CannotHostBehaviorMultipleTimesExceptionMessage), Culture);

        internal static string CannotHostTriggerActionMultipleTimesExceptionMessage =>
            ResourceManager.GetString(nameof(CannotHostTriggerActionMultipleTimesExceptionMessage), Culture);

        internal static string CannotHostTriggerCollectionMultipleTimesExceptionMessage =>
            ResourceManager.GetString(nameof(CannotHostTriggerCollectionMultipleTimesExceptionMessage), Culture);

        internal static string CannotHostTriggerMultipleTimesExceptionMessage =>
            ResourceManager.GetString(nameof(CannotHostTriggerMultipleTimesExceptionMessage), Culture);

        internal static string CommandDoesNotExistOnBehaviorWarningMessage =>
            ResourceManager.GetString(nameof(CommandDoesNotExistOnBehaviorWarningMessage), Culture);

        internal static string DefaultTriggerAttributeInvalidTriggerTypeSpecifiedExceptionMessage =>
            ResourceManager.GetString(nameof(DefaultTriggerAttributeInvalidTriggerTypeSpecifiedExceptionMessage),
                Culture);

        internal static string DuplicateItemInCollectionExceptionMessage =>
            ResourceManager.GetString(nameof(DuplicateItemInCollectionExceptionMessage), Culture);

        internal static string EventTriggerBaseInvalidEventExceptionMessage =>
            ResourceManager.GetString(nameof(EventTriggerBaseInvalidEventExceptionMessage), Culture);

        internal static string EventTriggerCannotFindEventNameExceptionMessage =>
            ResourceManager.GetString(nameof(EventTriggerCannotFindEventNameExceptionMessage), Culture);

        internal static string RetargetedTypeConstraintViolatedExceptionMessage =>
            ResourceManager.GetString(nameof(RetargetedTypeConstraintViolatedExceptionMessage), Culture);

        internal static string TypeConstraintViolatedExceptionMessage =>
            ResourceManager.GetString(nameof(TypeConstraintViolatedExceptionMessage), Culture);

        internal static string UnableToResolveTargetNameWarningMessage =>
            ResourceManager.GetString(nameof(UnableToResolveTargetNameWarningMessage), Culture);
    }
}