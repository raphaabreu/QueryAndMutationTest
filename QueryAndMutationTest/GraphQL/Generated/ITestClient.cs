using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace QueryAndMutationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface ITestClient
    {
        Task<IOperationResult<global::QueryAndMutationTest.IGetCount>> GetCountAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::QueryAndMutationTest.IGetCount>> GetCountAsync(
            GetCountOperation operation,
            CancellationToken cancellationToken = default);
    }
}
