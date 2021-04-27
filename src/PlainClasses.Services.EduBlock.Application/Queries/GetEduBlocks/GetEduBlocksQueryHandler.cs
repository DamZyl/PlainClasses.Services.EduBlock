using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using MicroserviceLibrary.Application.Configurations.Data;
using MicroserviceLibrary.Application.Configurations.Dispatchers;

namespace PlainClasses.Services.EduBlock.Application.Queries.GetEduBlocks
{
    public class GetEduBlocksQueryHandler : IQueryHandler<GetEduBlocksQuery, IEnumerable<EduBlockViewModel>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public GetEduBlocksQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        
        public async Task<IEnumerable<EduBlockViewModel>> Handle(GetEduBlocksQuery request, CancellationToken cancellationToken)
        {
            var connection = _sqlConnectionFactory.GetOpenConnection();
            
            const string sql = "SELECT " +
                               "[EduBlock].[Id], " +
                               "[EduBlock].[EduBlockSubjectName], " +
                               "[EduBlock].[StartEduBlock], " +
                               "[EduBlock].[EndEduBlock], " +
                               "[EduBlock].[Place] " +
                               "FROM EduBlocks AS [EduBlock] ";
            
            var eduBlocks = await connection.QueryAsync<EduBlockViewModel>(sql);

            return eduBlocks;
        }
    }
}