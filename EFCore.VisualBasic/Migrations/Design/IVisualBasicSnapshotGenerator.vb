﻿Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure
Imports Microsoft.EntityFrameworkCore.Metadata

Namespace Migrations.Design
    Public Interface IVisualBasicSnapshotGenerator
        ''' <summary>
        '''     Generates code for creating an <see cref="IModel" />.
        ''' </summary>
        ''' <param name="builderName"> The <see cref="ModelBuilder" /> variable name. </param>
        ''' <param name="model"> The model. </param>
        ''' <param name="stringBuilder"> The builder code Is added to. </param>
        Sub Generate(builderName As String,
                     model As IModel,
                     stringBuilder As IndentedStringBuilder)
    End Interface

End Namespace