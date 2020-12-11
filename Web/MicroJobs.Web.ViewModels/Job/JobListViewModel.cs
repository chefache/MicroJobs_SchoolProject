﻿namespace MicroJobs.Web.ViewModels.Job
{
    using System;
    using System.Collections.Generic;

    public class JobListViewModel : PagingViewModel
    {
        public IEnumerable<JobInListViewModel> Jobs { get; set; }
    }
}
