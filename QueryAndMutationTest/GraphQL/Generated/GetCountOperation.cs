using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace QueryAndMutationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCountOperation
        : IOperation<IGetCount>
    {
        public string Name => "GetCount";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetCount);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
