// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Microsoft.SemanticKernel;

/// <summary>
/// Content type to support file references.
/// </summary>
[Experimental("SKEXP0110")]
public class FileReferenceContent : KernelContent
{
    /// <summary>
    /// The file identifier.
    /// </summary>
    public string FileId { get; }

    /// <summary>
    /// The file URL.
    /// </summary>
    public Uri? FileUrl { get; set; }

    /// <summary>
    /// An optional tool association.
    /// </summary>
    /// <remarks>
    /// Tool definition depends upon the context within which the content is consumed.
    /// </remarks>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<string>? Tools { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileReferenceContent"/> class.
    /// </summary>
    /// <param name="fileId">The identifier of the referenced file.</param>
    [JsonConstructor]
    public FileReferenceContent(string fileId)
    {
        this.FileId = fileId;
    }
}
