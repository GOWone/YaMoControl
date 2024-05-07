/*********************************************************************
 * Copyright(c) YaMoStudio All Rights Reserved.
 * 开发者：YaMoStudio
 * 命名空间：YaMoControlDesign.Interactivity.Commands
 * 文件名：CommandHelpers
 * 版本号：V1.0.0.0
 * 创建时间：2024/5/4 21:22:43
 ******************************************************/
using System.Security;
using System.Windows;
using System.Windows.Input;


namespace YaMoControlDesign.Interactivity
{
    internal static class CommandHelpers
    {
        internal static bool CanExecuteCommandSource(ICommandSource commandSource)
        {
            var command = commandSource.Command;
            if (command == null)
            {
                return false;
            }

            var commandParameter = commandSource.CommandParameter ?? commandSource;
            if (command is RoutedCommand routedCommand)
            {
                var target = commandSource.CommandTarget ?? commandSource as IInputElement;
                return routedCommand.CanExecute(commandParameter, target);
            }

            return command.CanExecute(commandParameter);
        }

        [SecurityCritical]
        [SecuritySafeCritical]
        internal static void ExecuteCommandSource(ICommandSource commandSource)
        {
            CriticalExecuteCommandSource(commandSource);
        }

        [SecurityCritical]
        internal static void CriticalExecuteCommandSource(ICommandSource commandSource)
        {
            var command = commandSource.Command;
            if (command == null)
            {
                return;
            }

            var commandParameter = commandSource.CommandParameter ?? commandSource;
            if (command is RoutedCommand routedCommand)
            {
                var target = commandSource.CommandTarget ?? commandSource as IInputElement;
                if (routedCommand.CanExecute(commandParameter, target))
                {
                    routedCommand.Execute(commandParameter, target);
                }
            }
            else
            {
                if (command.CanExecute(commandParameter))
                {
                    command.Execute(commandParameter);
                }
            }
        }

        internal static bool CanExecuteCommandSource(ICommandSource commandSource, ICommand theCommand)
        {
            var command = theCommand;
            if (command == null)
            {
                return false;
            }

            var commandParameter = commandSource.CommandParameter ?? commandSource;
            if (command is RoutedCommand routedCommand)
            {
                var target = commandSource.CommandTarget ?? commandSource as IInputElement;
                return routedCommand.CanExecute(commandParameter, target);
            }

            return command.CanExecute(commandParameter);
        }

        [SecurityCritical]
        [SecuritySafeCritical]
        internal static void ExecuteCommandSource(ICommandSource commandSource, ICommand theCommand)
        {
            CriticalExecuteCommandSource(commandSource, theCommand);
        }

        [SecurityCritical]
        internal static void CriticalExecuteCommandSource(ICommandSource commandSource, ICommand theCommand)
        {
            var command = theCommand;
            if (command == null)
            {
                return;
            }

            var commandParameter = commandSource.CommandParameter ?? commandSource;
            if (command is RoutedCommand routedCommand)
            {
                var target = commandSource.CommandTarget ?? commandSource as IInputElement;
                if (routedCommand.CanExecute(commandParameter, target))
                {
                    routedCommand.Execute(commandParameter, target);
                }
            }
            else
            {
                if (command.CanExecute(commandParameter))
                {
                    command.Execute(commandParameter);
                }
            }
        }
    }
}
