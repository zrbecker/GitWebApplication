﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GitWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGitWebService" in both code and config file together.
    [ServiceContract]
    public interface IGitWebService
    {
        [OperationContract]
        CreateGitRepositoryResponse CreateGitRepository(string repositoryName);
    }
}
