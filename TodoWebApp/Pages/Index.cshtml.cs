﻿// https://www.learnrazorpages.com/razor-pages/forms/checkboxes
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoWebApp.Services;
using TodoWebApp.Data;
using System.Linq;
using System;

namespace TodoWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITodoService _service;

        public IndexModel(ILogger<IndexModel> logger, ITodoService service)
        {
            _logger = logger;
            _service = service;
        }

        [BindProperty]
        public List<TodoItem> TodoItems { get; set; }

        [BindProperty]
        public PriorityLevel Priority { get; set; }


        public async Task OnGetCheckAsync(Guid id)
        {
            await _service.UpdateIsDone(id);
            TodoItems = await _service.GetAll();
        }

        public async Task OnGetAsync()
        {
            TodoItems = await _service.GetAll();
        }
    }
}
