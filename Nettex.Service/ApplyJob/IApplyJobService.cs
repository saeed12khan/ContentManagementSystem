﻿using Nettex.Core.Entities;
using System.Collections.Generic;

namespace Nettex.Service
{
    public interface IApplyJobService
    {
        IEnumerable<ApplyJob> GetApplyJobs();
        IEnumerable<ApplyJob> GetApplyJobsByJobId(int jobId);
        ApplyJob GetById(int Id);
        bool Save(ApplyJob job);
        bool Delete(ApplyJob applyJob);
    }
}