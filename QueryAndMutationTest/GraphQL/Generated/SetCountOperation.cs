using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace QueryAndMutationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SetCountOperation
        : IOperation<ISetCount>
    {
        public string Name => "SetCount";

        public IDocument Document => Mutations.Default;

        public OperationKind Kind => OperationKind.Mutation;

        public Type ResultType => typeof(ISetCount);

        public Optional<int> Count { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (Count.HasValue)
            {
                variables.Add(new VariableValue("count", "Int", Count.Value));
            }

            return variables;
        }
    }
}
