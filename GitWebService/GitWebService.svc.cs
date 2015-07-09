using LibGit2Sharp;
using System;
using System.IO;

namespace GitWebService
{
    public class GitWebService : IGitWebService
    {
        private string _repositoryDirectory = @"C:\Users\Zachary\Documents\Repositories";

        public CreateGitRepositoryResponse CreateGitRepository(string repositoryName)
        {
            try
            {
                string fileName = string.Format("{0}.git", repositoryName);
                string filePath = Path.Combine(_repositoryDirectory, fileName);

                if (File.Exists(filePath) || Directory.Exists(filePath))
                {
                    return new CreateGitRepositoryResponse()
                    {
                        Status = GitWebServiceStatus.InvalidRequest,
                        ErrorMessage = "File already exists"
                    };
                }

                Repository.Init(filePath, true);

                return new CreateGitRepositoryResponse()
                {
                    Status = GitWebServiceStatus.Success
                };
            }
            catch (Exception ex)
            {
                return new CreateGitRepositoryResponse()
                {
                    Status = GitWebServiceStatus.ServerError,
                    ErrorMessage = "Unexpected exception was thrown."
                };
            }
        }
    }
}