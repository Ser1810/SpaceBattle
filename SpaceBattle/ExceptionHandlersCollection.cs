using SpaceBattle.Commands;
using SpaceBattle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle
{
    /*public static class ExceptionHandlersCollection
    {
        public static Func<ICommand, Exception, ICommand> AddToQueueExceptionToLogCommandExceptionHandler => (c, e) =>
        {
            var command = new WriteToLogCommand(c, e);
            return new AddToQueueCommand(command, r);
        };

        public static Func<ICommand, Exception, ICommand> AddToQueueRetryCommandExceptionHandler => (c, e) =>
        {
            var command = new RetryCommand(c);
            return new AddToQueueCommand(command);
        };

        public static Func<ICommand, Exception, ICommand> AddToQueueThirdTryCommandExceptionHandler => (c, e) =>
        {
            var command = new ThirdTryCommand(c);
            return new AddToQueueCommand(command);
        };
    }*/
}
