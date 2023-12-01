﻿
namespace Carbook.Application.Features.CQRS.Commands.ContactCommands
{
    public class RemoveContactCommand
    {
        public int ContactId { get; set; }

        public RemoveContactCommand(int contactId)
        {
            ContactId = contactId;
        }
    }
}
