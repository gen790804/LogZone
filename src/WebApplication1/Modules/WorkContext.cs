﻿using MDP.Registration;

namespace WebApplication1
{
    [Service<WorkContext>()]
    public class WorkContext
    {
        // Fields
        private readonly WorkService _workService;


        // Constructors
        public WorkContext(WorkService workService)
        {
            // Default
            _workService = workService;
        }


        // Methods
        public string GetValue()
        {
            // Return
            return _workService.GetValue();
        }
    }

    public interface WorkService
    {
        // Methods
        string GetValue();
    }
}

namespace WebApplication1
{
    [Service<WorkService>()]
    public class MessageService : WorkService
    {
        // Fields
        private readonly string _message;


        // Constructors
        public MessageService(string message)
        {
            // Default
            _message = message;
        }


        // Methods
        public string GetValue()
        {
            // Return
            return _message;
        }
    }
}
