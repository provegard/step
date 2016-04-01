﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using IxMilia.Step.Tokens;

namespace IxMilia.Step.Syntax
{
    internal class StepEntityInstanceReferenceSyntax : StepSyntax
    {
        public override StepSyntaxType SyntaxType => StepSyntaxType.EntityInstanceReference;

        public int Id { get; }

        public StepEntityInstanceReferenceSyntax(int id)
            : base(-1, -1)
        {
            Id = id;
        }

        public StepEntityInstanceReferenceSyntax(StepEntityInstanceToken entityInstance)
            : base(entityInstance.Line, entityInstance.Column)
        {
            Id = entityInstance.Id;
        }

        public override string ToString(StepWriter writer)
        {
            return "#" + Id;
        }
    }
}