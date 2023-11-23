using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public int id { get; set; }
        public RemoveAboutCommand(int id)
        {
            this.id = id;
        }
    }
}
