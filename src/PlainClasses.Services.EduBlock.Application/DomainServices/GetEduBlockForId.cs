using System;
using System.Threading.Tasks;
using Dapper;
using MicroserviceLibrary.Application.Configurations.Data;
using PlainClasses.Services.EduBlock.Domain.Models.DomainServices;

namespace PlainClasses.Services.EduBlock.Application.DomainServices
{
    public class GetEduBlockForId : IGetEduBlockForId
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public GetEduBlockForId(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        
        public Domain.Models.EduBlock Get(Guid eduBlockId)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            
            const string sql = "SELECT " +
                               "[EduBlock].[Id] " +
                               "FROM EduBlocks AS [EduBlock] " +
                               "WHERE [EduBlock].[Id] = @EduBlockId ";
            
            var eduBlock = connection.QuerySingleOrDefault<Domain.Models.EduBlock>(sql, new { eduBlockId });

            return eduBlock;
        }

        public async Task<Domain.Models.EduBlock> GetAsync(Guid eduBlockId)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            
            const string sql = "SELECT " +
                               "[EduBlock].[Id] " +
                               "FROM EduBlocks AS [EduBlock] " +
                               "WHERE [EduBlock].[Id] = @EduBlockId ";
            
            var eduBlock = await connection.QuerySingleOrDefaultAsync<Domain.Models.EduBlock>(sql, new { eduBlockId });

            return eduBlock;
        }

        public async Task<Domain.Models.EduBlock> GetDetailAsync(Guid eduBlockId)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            
            const string sql = "SELECT " +
                               "[EduBlock].[Id], " +
                               "[EduBlock].[EduBlockSubjectId], " +
                               "[EduBlock].[EduBlockSubjectName], " +
                               "[EduBlock].[Remarks], " +
                               "[EduBlock].[Place], " +
                               "[EduBlock].[StartEduBlock], " +
                               "[EduBlock].[EndEduBlock] " +
                               "FROM EduBlocks AS [EduBlock] " +
                               "WHERE [EduBlock].[Id] = @EduBlockId ";
            
            var eduBlock = await connection.QuerySingleOrDefaultAsync<Domain.Models.EduBlock>(sql, new { eduBlockId });

            return eduBlock;
        }
    }
}