using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Notifications
{
    public class EstoqueNotification : INotification
    {
        public ActionNotification? Action { get; set; }
        public EstoqueQuery? Estoque { get; set; }
    }
}
