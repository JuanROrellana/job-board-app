using System.Collections.Generic;
using JobBoardApp.Models;

namespace JobBoardApp.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<JobBoard> JobBoards { get; set; }
    }
}