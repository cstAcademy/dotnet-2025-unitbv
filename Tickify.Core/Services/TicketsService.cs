using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Repositories;

namespace Tickify.Core.Services
{
    public class TicketsService
    {
        private readonly TicketsRepository _ticketsRepository;
        private readonly UserTicketsRepository _userTicketsRepository;
        private readonly SingletonService _singletonService;

        public TicketsService(TicketsRepository ticketsRepository, UserTicketsRepository userTicketsRepository, SingletonService singletonService)
        {
            Console.WriteLine("TicketsService initialized");

            _ticketsRepository = ticketsRepository;
            _userTicketsRepository = userTicketsRepository;
            _singletonService = singletonService;
        }
    }
}
